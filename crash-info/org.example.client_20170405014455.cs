S/W Version Information
Model: SM-Z300H
Tizen-Version: 2.4.0.3
Build-Number: Z300HDDU0BPI2
Build-Date: 2016.09.30 15:37:12

Crash Information
Process Name: client
PID: 30826
Date: 2017-04-05 01:44:55+0900
Executable File Path: /opt/usr/apps/org.example.client/bin/client
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 30826, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0x80044e29
r2   = 0x8004be61, r3   = 0x8004be61
r4   = 0x8004be61, r5   = 0xb8010320
r6   = 0x40000046, r7   = 0xbebaa038
r8   = 0x80044e29, r9   = 0xb6e04eac
r10  = 0xb279e309, fp   = 0x00000000
ip   = 0x80044e29, sp   = 0xbebaa020
lr   = 0x00000000, pc   = 0xb279e31c
cpsr = 0x80030030

Memory Information
MemTotal:   987012 KB
MemFree:     52192 KB
Buffers:     54880 KB
Cached:     281156 KB
VmPeak:     124456 KB
VmSize:     124452 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       27400 KB
VmRSS:       27400 KB
VmData:      36424 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       35748 KB
VmPTE:          98 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 30826 TID = 30826
30826 30828 31079 31080 

Maps Information
b1022000 b1033000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b1043000 b1048000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b1346000 b134e000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b1360000 b1b5f000 rw-p [stack:31080]
b1b5f000 b1b60000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b1b70000 b1b84000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b1b98000 b1b99000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b1ba9000 b1bac000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b1bbd000 b1bbe000 r-xp /usr/lib/libxshmfence.so.1.0.0
b1bce000 b1bd0000 r-xp /usr/lib/libxcb-present.so.0.0.0
b1be0000 b1be2000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b1bf2000 b1c02000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b1c12000 b1c1e000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b1c30000 b242f000 rw-p [stack:31079]
b2760000 b2767000 r-xp /usr/lib/libefl-extension.so.0.1.0
b277a000 b2780000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b2790000 b27a4000 r-xp /opt/usr/apps/org.example.client/bin/client
b28fd000 b29e0000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2a17000 b2a3f000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2a51000 b3250000 rw-p [stack:30828]
b3250000 b3252000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b3262000 b326c000 r-xp /lib/libnss_files-2.20-2014.11.so
b327d000 b3286000 r-xp /lib/libnss_nis-2.20-2014.11.so
b3297000 b32a8000 r-xp /lib/libnsl-2.20-2014.11.so
b32bb000 b32c1000 r-xp /lib/libnss_compat-2.20-2014.11.so
b32d2000 b32d3000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b32fb000 b3302000 r-xp /usr/lib/libminizip.so.1.0.0
b3312000 b3317000 r-xp /usr/lib/libstorage.so.0.1
b3327000 b3386000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b339c000 b33b0000 r-xp /usr/lib/libcapi-media-camera.so.0.1.90
b33c0000 b3404000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b3414000 b341c000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b342c000 b345c000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b346f000 b3528000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b353c000 b358f000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b35a0000 b35bb000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b35cb000 b368c000 r-xp /usr/lib/libprotobuf.so.9.0.1
b369f000 b36af000 r-xp /usr/lib/libefl-assist.so.0.1.0
b36bf000 b36cc000 r-xp /usr/lib/libmdm-common.so.1.0.98
b36dd000 b36e4000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b36f4000 b3735000 r-xp /usr/lib/libmdm.so.1.2.12
b3745000 b374d000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b375c000 b376c000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b378d000 b37ed000 r-xp /usr/lib/libasound.so.2.0.0
b37ff000 b3802000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b3812000 b3815000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b3825000 b382a000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b383a000 b383b000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b384b000 b3856000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b386a000 b3871000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b3881000 b3887000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b3897000 b389c000 r-xp /usr/lib/libmmfsession.so.0.0.1
b38ac000 b38c7000 r-xp /usr/lib/libmmfsound.so.0.1.0
b38d7000 b38de000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b38ee000 b38f1000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b3902000 b3930000 r-xp /usr/lib/libidn.so.11.5.44
b3940000 b3956000 r-xp /usr/lib/libnghttp2.so.5.4.0
b3967000 b3971000 r-xp /usr/lib/libcares.so.2.1.0
b3981000 b398b000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.32
b399b000 b399d000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.18
b39ad000 b39ae000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b39be000 b39c2000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b39d3000 b39fb000 r-xp /usr/lib/libui-extension.so.0.1.0
b3a0c000 b3a35000 r-xp /usr/lib/libturbojpeg.so
b3a55000 b3a5b000 r-xp /usr/lib/libgif.so.4.1.6
b3a6b000 b3ab1000 r-xp /usr/lib/libcurl.so.4.3.0
b3ac2000 b3ae3000 r-xp /usr/lib/libexif.so.12.3.3
b3afe000 b3b13000 r-xp /usr/lib/libtts.so
b3b24000 b3b2c000 r-xp /usr/lib/libfeedback.so.0.1.4
b3b3c000 b3c02000 r-xp /usr/lib/libdali-core.so.0.0.0
b3c22000 b3d1a000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b3d39000 b3e07000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b3e1e000 b3e20000 r-xp /usr/lib/libboost_system.so.1.51.0
b3e30000 b3e36000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b3e46000 b3e69000 r-xp /usr/lib/libboost_thread.so.1.51.0
b3e7a000 b3e7c000 r-xp /usr/lib/libappsvc.so.0.1.0
b3e8c000 b3e8e000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b3e9f000 b3ea4000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b3ebb000 b3ebd000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b3ecd000 b3ed4000 r-xp /usr/lib/libsensord-share.so
b3ee4000 b3efc000 r-xp /usr/lib/libsensor.so.1.1.0
b3f0d000 b3f10000 r-xp /usr/lib/libXv.so.1.0.0
b3f20000 b3f25000 r-xp /usr/lib/libutilX.so.1.1.0
b3f35000 b3f3a000 r-xp /usr/lib/libappcore-common.so.1.1
b3f4a000 b3f51000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.11
b3f64000 b3f68000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b3f79000 b4057000 r-xp /usr/lib/libCOREGL.so.4.0
b4077000 b407a000 r-xp /usr/lib/libuuid.so.1.3.0
b408a000 b40a1000 r-xp /usr/lib/libblkid.so.1.1.0
b40b2000 b40b4000 r-xp /usr/lib/libXau.so.6.0.0
b40c4000 b410b000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b411d000 b4123000 r-xp /usr/lib/libjson-c.so.2.0.1
b4134000 b4138000 r-xp /usr/lib/libogg.so.0.7.1
b4148000 b416a000 r-xp /usr/lib/libvorbis.so.0.4.3
b417a000 b425e000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b427a000 b427d000 r-xp /usr/lib/libEGL.so.1.4
b428e000 b4294000 r-xp /usr/lib/libxcb-render.so.0.0.0
b42a4000 b42a6000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b42b6000 b42c3000 r-xp /usr/lib/libGLESv2.so.2.0
b42d4000 b4336000 r-xp /usr/lib/libpixman-1.so.0.28.2
b434b000 b4363000 r-xp /usr/lib/libmount.so.1.1.0
b4375000 b4389000 r-xp /usr/lib/libxcb.so.1.1.0
b4399000 b43a0000 r-xp /lib/libcrypt-2.20-2014.11.so
b43d8000 b43da000 r-xp /usr/lib/libiri.so
b43ea000 b43f5000 r-xp /usr/lib/libgpg-error.so.0.15.0
b4406000 b443c000 r-xp /usr/lib/libpulse.so.0.16.2
b444d000 b4490000 r-xp /usr/lib/libsndfile.so.1.0.25
b44a5000 b44ba000 r-xp /lib/libexpat.so.1.5.2
b44cc000 b458a000 r-xp /usr/lib/libcairo.so.2.11200.14
b459e000 b45a6000 r-xp /usr/lib/libdrm.so.2.4.0
b45b6000 b45b9000 r-xp /usr/lib/libdri2.so.0.0.0
b45c9000 b4617000 r-xp /usr/lib/libssl.so.1.0.0
b462c000 b4638000 r-xp /usr/lib/libeeze.so.1.13.0
b4649000 b4652000 r-xp /usr/lib/libethumb.so.1.13.0
b4662000 b4665000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b4675000 b482c000 r-xp /usr/lib/libcrypto.so.1.0.0
b5617000 b5620000 r-xp /usr/lib/libXi.so.6.1.0
b5630000 b5632000 r-xp /usr/lib/libXgesture.so.7.0.0
b5642000 b5646000 r-xp /usr/lib/libXtst.so.6.1.0
b5656000 b565c000 r-xp /usr/lib/libXrender.so.1.3.0
b566c000 b5672000 r-xp /usr/lib/libXrandr.so.2.2.0
b5682000 b5684000 r-xp /usr/lib/libXinerama.so.1.0.0
b5695000 b5698000 r-xp /usr/lib/libXfixes.so.3.1.0
b56a8000 b56b3000 r-xp /usr/lib/libXext.so.6.4.0
b56c3000 b56c5000 r-xp /usr/lib/libXdamage.so.1.1.0
b56d5000 b56d7000 r-xp /usr/lib/libXcomposite.so.1.0.0
b56e7000 b57c9000 r-xp /usr/lib/libX11.so.6.3.0
b57dd000 b57e4000 r-xp /usr/lib/libXcursor.so.1.0.2
b57f4000 b580c000 r-xp /usr/lib/libudev.so.1.6.0
b580e000 b5811000 r-xp /lib/libattr.so.1.1.0
b5821000 b5841000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5842000 b5847000 r-xp /usr/lib/libffi.so.6.0.2
b5858000 b5870000 r-xp /lib/libz.so.1.2.8
b5880000 b5882000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b5892000 b5967000 r-xp /usr/lib/libxml2.so.2.9.2
b597c000 b5a17000 r-xp /usr/lib/libstdc++.so.6.0.20
b5a33000 b5a36000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5a46000 b5a5f000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5a70000 b5a81000 r-xp /lib/libresolv-2.20-2014.11.so
b5a95000 b5b0f000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5b24000 b5b26000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5b36000 b5b3d000 r-xp /usr/lib/libembryo.so.1.13.0
b5b4d000 b5b57000 r-xp /usr/lib/libecore_audio.so.1.13.0
b5b68000 b5b80000 r-xp /usr/lib/libpng12.so.0.50.0
b5b91000 b5bb4000 r-xp /usr/lib/libjpeg.so.8.0.2
b5bd5000 b5be9000 r-xp /usr/lib/libector.so.1.13.0
b5bfa000 b5c12000 r-xp /usr/lib/liblua-5.1.so
b5c23000 b5c7a000 r-xp /usr/lib/libfreetype.so.6.11.3
b5c8e000 b5cb6000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5cc7000 b5cda000 r-xp /usr/lib/libfribidi.so.0.3.1
b5ceb000 b5d25000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5d36000 b5d44000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5d54000 b5d5c000 r-xp /usr/lib/libtbm.so.1.0.0
b5d6c000 b5d79000 r-xp /usr/lib/libeio.so.1.13.0
b5d89000 b5d8b000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5d9b000 b5da0000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5db0000 b5dc7000 r-xp /usr/lib/libefreet.so.1.13.0
b5dd9000 b5df9000 r-xp /usr/lib/libeldbus.so.1.13.0
b5e09000 b5e29000 r-xp /usr/lib/libecore_con.so.1.13.0
b5e2b000 b5e31000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5e41000 b5e52000 r-xp /usr/lib/libemotion.so.1.13.0
b5e63000 b5e6a000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5e7a000 b5e89000 r-xp /usr/lib/libeo.so.1.13.0
b5e9a000 b5eac000 r-xp /usr/lib/libecore_input.so.1.13.0
b5ebd000 b5ec2000 r-xp /usr/lib/libecore_file.so.1.13.0
b5ed2000 b5eeb000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5efb000 b5f18000 r-xp /usr/lib/libeet.so.1.13.0
b5f31000 b5f79000 r-xp /usr/lib/libeina.so.1.13.0
b5f8a000 b5f9a000 r-xp /usr/lib/libefl.so.1.13.0
b5fab000 b6090000 r-xp /usr/lib/libicuuc.so.51.1
b60ad000 b61ed000 r-xp /usr/lib/libicui18n.so.51.1
b6204000 b623c000 r-xp /usr/lib/libecore_x.so.1.13.0
b624e000 b6251000 r-xp /lib/libcap.so.2.21
b6261000 b628a000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b629b000 b62a2000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b62b4000 b62eb000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b62fc000 b63e7000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b63fa000 b6473000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6485000 b648a000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b649a000 b64a4000 r-xp /usr/lib/libvconf.so.0.2.45
b64b4000 b64b6000 r-xp /usr/lib/libvasum.so.0.3.1
b64c6000 b64c8000 r-xp /usr/lib/libttrace.so.1.1
b64d8000 b64db000 r-xp /usr/lib/libiniparser.so.0
b64eb000 b6511000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6521000 b6526000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6537000 b654e000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b655f000 b65ca000 r-xp /lib/libm-2.20-2014.11.so
b65db000 b65e1000 r-xp /lib/librt-2.20-2014.11.so
b65f2000 b65ff000 r-xp /usr/lib/libunwind.so.8.0.1
b6635000 b6759000 r-xp /lib/libc-2.20-2014.11.so
b676e000 b6787000 r-xp /lib/libgcc_s-4.9.so.1
b6797000 b6879000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b688a000 b68b4000 r-xp /usr/lib/libdbus-1.so.3.8.12
b68c5000 b6901000 r-xp /usr/lib/libsystemd.so.0.4.0
b6903000 b6986000 r-xp /usr/lib/libedje.so.1.13.0
b6999000 b69b7000 r-xp /usr/lib/libecore.so.1.13.0
b69d7000 b6b5e000 r-xp /usr/lib/libevas.so.1.13.0
b6b93000 b6ba7000 r-xp /lib/libpthread-2.20-2014.11.so
b6bbb000 b6def000 r-xp /usr/lib/libelementary.so.1.13.0
b6e1e000 b6e22000 r-xp /usr/lib/libsmack.so.1.0.0
b6e32000 b6e39000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6e49000 b6e4b000 r-xp /usr/lib/libdlog.so.0.0.0
b6e5b000 b6e5e000 r-xp /usr/lib/libbundle.so.0.1.22
b6e6e000 b6e70000 r-xp /lib/libdl-2.20-2014.11.so
b6e81000 b6e99000 r-xp /usr/lib/libaul.so.0.1.0
b6ead000 b6eb2000 r-xp /usr/lib/libappcore-efl.so.1.1
b6ec3000 b6ed0000 r-xp /usr/lib/liblptcp.so
b6ee2000 b6ee6000 r-xp /usr/lib/libsys-assert.so
b6ef7000 b6f17000 r-xp /lib/ld-2.20-2014.11.so
b6f28000 b6f2d000 r-xp /usr/bin/launchpad-loader
b7cbb000 b807f000 rw-p [heap]
beb8a000 bebab000 rw-p [stack]
End of Maps Information

Callstack Information (PID:30826)
Call Stack Count: 22
 0: _ZN8ListItem11selected_cbEPvP10_Eo_OpaqueS0_ + 0x13 (0xb279e31c) [/opt/usr/apps/org.example.client/bin/client] + 0xe31c
 1: (0xb6cf760b) [/usr/lib/libelementary.so.1] + 0x13c60b
 2: (0xb6cf817d) [/usr/lib/libelementary.so.1] + 0x13d17d
 3: (0xb6a0c175) [/usr/lib/libevas.so.1] + 0x35175
 4: (0xb5e85219) [/usr/lib/libeo.so.1] + 0xb219
 5: eo_event_callback_call + 0x68 (0xb5e83fb9) [/usr/lib/libeo.so.1] + 0x9fb9
 6: (0xb6a0c515) [/usr/lib/libevas.so.1] + 0x35515
 7: (0xb6a0c5bf) [/usr/lib/libevas.so.1] + 0x355bf
 8: (0xb6a14de7) [/usr/lib/libevas.so.1] + 0x3dde7
 9: evas_canvas_event_feed_mouse_up + 0x6a (0xb6a19ea7) [/usr/lib/libevas.so.1] + 0x42ea7
10: evas_event_feed_mouse_up + 0x30 (0xb6a1d8e9) [/usr/lib/libevas.so.1] + 0x468e9
11: (0xb46641cb) [/usr/lib/libecore_input_evas.so.1] + 0x21cb
12: (0xb69a4c4b) [/usr/lib/libecore.so.1] + 0xbc4b
13: (0xb69aaa5d) [/usr/lib/libecore.so.1] + 0x11a5d
14: ecore_main_loop_begin + 0x3e (0xb69aac83) [/usr/lib/libecore.so.1] + 0x11c83
15: appcore_efl_main + 0x20c (0xb6eb02bd) [/usr/lib/libappcore-efl.so.1] + 0x32bd
16: ui_app_main + 0xc0 (0xb3f66909) [/usr/lib/libcapi-appfw-application.so.0] + 0x2909
17: _ZN6Window10makeWindowEiPPc + 0x11e (0xb279c0ef) [/opt/usr/apps/org.example.client/bin/client] + 0xc0ef
18: main + 0x40 (0xb279403d) [/opt/usr/apps/org.example.client/bin/client] + 0x403d
19: (0xb6f29bb5) [/opt/usr/apps/org.example.client/bin/client] + 0x1bb5
20: __libc_start_main + 0x114 (0xb664b4bc) [/lib/libc.so.6] + 0x164bc
21: (0xb6f29eb4) [/opt/usr/apps/org.example.client/bin/client] + 0x1eb4
End of Call Stack

Package Information
Package Name: org.example.client
Package ID : org.example.client
Version: 1.0.0
Package Type: tpk
App Name: client
App ID: org.example.client
Type: capp
Categories: 

Latest Debug Message Information
--------- beginning of /dev/log_main
erminate_pid[-3] fail
04-05 01:44:24.258+0900 E/PKGMGR_SERVER(30868): [0;m
04-05 01:44:24.258+0900 W/AUL     (30868): launch.c: app_request_to_launchpad(396) > request cmd(5) to(3136)
04-05 01:44:24.258+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 5
04-05 01:44:24.258+0900 E/AUL_AMD (  610): amd_request.c: __app_process_by_pid(272) > pid(3136) is dead. cmd(5) is canceled
04-05 01:44:24.258+0900 W/AUL     (30868): launch.c: app_request_to_launchpad(425) > request cmd(5) result(-3)
04-05 01:44:24.258+0900 E/PKGMGR_SERVER(30868): pkgmgr-server.c: __terminate_app(1401) > [0;31m[__terminate_app(): 1401](ret < 0) aul_terminate_pid[-3] fail
04-05 01:44:24.258+0900 E/PKGMGR_SERVER(30868): [0;m
04-05 01:44:24.258+0900 W/AUL     (30868): launch.c: app_request_to_launchpad(396) > request cmd(5) to(3407)
04-05 01:44:24.258+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 5
04-05 01:44:24.258+0900 E/AUL_AMD (  610): amd_request.c: __app_process_by_pid(272) > pid(3407) is dead. cmd(5) is canceled
04-05 01:44:24.258+0900 W/AUL     (30868): launch.c: app_request_to_launchpad(425) > request cmd(5) result(-3)
04-05 01:44:24.258+0900 E/PKGMGR_SERVER(30868): pkgmgr-server.c: __terminate_app(1401) > [0;31m[__terminate_app(): 1401](ret < 0) aul_terminate_pid[-3] fail
04-05 01:44:24.258+0900 E/PKGMGR_SERVER(30868): [0;m
04-05 01:44:24.258+0900 W/AUL     (30868): launch.c: app_request_to_launchpad(396) > request cmd(5) to(3679)
04-05 01:44:24.258+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 5
04-05 01:44:24.258+0900 E/AUL_AMD (  610): amd_request.c: __app_process_by_pid(272) > pid(3679) is dead. cmd(5) is canceled
04-05 01:44:24.258+0900 W/AUL     (30868): launch.c: app_request_to_launchpad(425) > request cmd(5) result(-3)
04-05 01:44:24.258+0900 E/PKGMGR_SERVER(30868): pkgmgr-server.c: __terminate_app(1401) > [0;31m[__terminate_app(): 1401](ret < 0) aul_terminate_pid[-3] fail
04-05 01:44:24.258+0900 E/PKGMGR_SERVER(30868): [0;m
04-05 01:44:24.258+0900 W/AUL     (30868): launch.c: app_request_to_launchpad(396) > request cmd(5) to(3974)
04-05 01:44:24.258+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 5
04-05 01:44:24.258+0900 E/AUL_AMD (  610): amd_request.c: __app_process_by_pid(272) > pid(3974) is dead. cmd(5) is canceled
04-05 01:44:24.258+0900 W/AUL     (30868): launch.c: app_request_to_launchpad(425) > request cmd(5) result(-3)
04-05 01:44:24.258+0900 E/PKGMGR_SERVER(30868): pkgmgr-server.c: __terminate_app(1401) > [0;31m[__terminate_app(): 1401](ret < 0) aul_terminate_pid[-3] fail
04-05 01:44:24.258+0900 E/PKGMGR_SERVER(30868): [0;m
04-05 01:44:24.258+0900 W/AUL     (30868): launch.c: app_request_to_launchpad(396) > request cmd(5) to(4251)
04-05 01:44:24.258+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 5
04-05 01:44:24.258+0900 E/AUL_AMD (  610): amd_request.c: __app_process_by_pid(272) > pid(4251) is dead. cmd(5) is canceled
04-05 01:44:24.258+0900 W/AUL     (30868): launch.c: app_request_to_launchpad(425) > request cmd(5) result(-3)
04-05 01:44:24.258+0900 E/PKGMGR_SERVER(30868): pkgmgr-server.c: __terminate_app(1401) > [0;31m[__terminate_app(): 1401](ret < 0) aul_terminate_pid[-3] fail
04-05 01:44:24.258+0900 E/PKGMGR_SERVER(30868): [0;m
04-05 01:44:24.258+0900 W/AUL     (30868): launch.c: app_request_to_launchpad(396) > request cmd(5) to(4524)
04-05 01:44:24.258+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 5
04-05 01:44:24.258+0900 E/AUL_AMD (  610): amd_request.c: __app_process_by_pid(272) > pid(4524) is dead. cmd(5) is canceled
04-05 01:44:24.258+0900 W/AUL     (30868): launch.c: app_request_to_launchpad(425) > request cmd(5) result(-3)
04-05 01:44:24.258+0900 E/PKGMGR_SERVER(30868): pkgmgr-server.c: __terminate_app(1401) > [0;31m[__terminate_app(): 1401](ret < 0) aul_terminate_pid[-3] fail
04-05 01:44:24.258+0900 E/PKGMGR_SERVER(30868): [0;m
04-05 01:44:24.258+0900 W/AUL     (30868): launch.c: app_request_to_launchpad(396) > request cmd(5) to(4794)
04-05 01:44:24.258+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 5
04-05 01:44:24.258+0900 E/AUL_AMD (  610): amd_request.c: __app_process_by_pid(272) > pid(4794) is dead. cmd(5) is canceled
04-05 01:44:24.258+0900 W/AUL     (30868): launch.c: app_request_to_launchpad(425) > request cmd(5) result(-3)
04-05 01:44:24.258+0900 E/PKGMGR_SERVER(30868): pkgmgr-server.c: __terminate_app(1401) > [0;31m[__terminate_app(): 1401](ret < 0) aul_terminate_pid[-3] fail
04-05 01:44:24.258+0900 E/PKGMGR_SERVER(30868): [0;m
04-05 01:44:24.258+0900 W/AUL     (30868): launch.c: app_request_to_launchpad(396) > request cmd(5) to(5107)
04-05 01:44:24.258+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 5
04-05 01:44:24.258+0900 E/AUL_AMD (  610): amd_request.c: __app_process_by_pid(272) > pid(5107) is dead. cmd(5) is canceled
04-05 01:44:24.258+0900 W/AUL     (30868): launch.c: app_request_to_launchpad(425) > request cmd(5) result(-3)
04-05 01:44:24.258+0900 E/PKGMGR_SERVER(30868): pkgmgr-server.c: __terminate_app(1401) > [0;31m[__terminate_app(): 1401](ret < 0) aul_terminate_pid[-3] fail
04-05 01:44:24.258+0900 E/PKGMGR_SERVER(30868): [0;m
04-05 01:44:24.258+0900 W/AUL     (30868): launch.c: app_request_to_launchpad(396) > request cmd(5) to(5381)
04-05 01:44:24.268+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 5
04-05 01:44:24.268+0900 E/AUL_AMD (  610): amd_request.c: __app_process_by_pid(272) > pid(5381) is dead. cmd(5) is canceled
04-05 01:44:24.268+0900 W/AUL     (30868): launch.c: app_request_to_launchpad(425) > request cmd(5) result(-3)
04-05 01:44:24.268+0900 E/PKGMGR_SERVER(30868): pkgmgr-server.c: __terminate_app(1401) > [0;31m[__terminate_app(): 1401](ret < 0) aul_terminate_pid[-3] fail
04-05 01:44:24.268+0900 E/PKGMGR_SERVER(30868): [0;m
04-05 01:44:24.268+0900 W/AUL     (30868): launch.c: app_request_to_launchpad(396) > request cmd(5) to(5733)
04-05 01:44:24.268+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 5
04-05 01:44:24.268+0900 E/AUL_AMD (  610): amd_request.c: __app_process_by_pid(272) > pid(5733) is dead. cmd(5) is canceled
04-05 01:44:24.268+0900 W/AUL     (30868): launch.c: app_request_to_launchpad(425) > request cmd(5) result(-3)
04-05 01:44:24.268+0900 E/PKGMGR_SERVER(30868): pkgmgr-server.c: __terminate_app(1401) > [0;31m[__terminate_app(): 1401](ret < 0) aul_terminate_pid[-3] fail
04-05 01:44:24.268+0900 E/PKGMGR_SERVER(30868): [0;m
04-05 01:44:24.268+0900 W/AUL     (30868): launch.c: app_request_to_launchpad(396) > request cmd(5) to(5856)
04-05 01:44:24.268+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 5
04-05 01:44:24.268+0900 E/AUL_AMD (  610): amd_request.c: __app_process_by_pid(272) > pid(5856) is dead. cmd(5) is canceled
04-05 01:44:24.268+0900 W/AUL     (30868): launch.c: app_request_to_launchpad(425) > request cmd(5) result(-3)
04-05 01:44:24.268+0900 E/PKGMGR_SERVER(30868): pkgmgr-server.c: __terminate_app(1401) > [0;31m[__terminate_app(): 1401](ret < 0) aul_terminate_pid[-3] fail
04-05 01:44:24.268+0900 E/PKGMGR_SERVER(30868): [0;m
04-05 01:44:24.268+0900 W/AUL     (30868): launch.c: app_request_to_launchpad(396) > request cmd(5) to(6127)
04-05 01:44:24.268+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 5
04-05 01:44:24.268+0900 E/AUL_AMD (  610): amd_request.c: __app_process_by_pid(272) > pid(6127) is dead. cmd(5) is canceled
04-05 01:44:24.268+0900 W/AUL     (30868): launch.c: app_request_to_launchpad(425) > request cmd(5) result(-3)
04-05 01:44:24.268+0900 E/PKGMGR_SERVER(30868): pkgmgr-server.c: __terminate_app(1401) > [0;31m[__terminate_app(): 1401](ret < 0) aul_terminate_pid[-3] fail
04-05 01:44:24.268+0900 E/PKGMGR_SERVER(30868): [0;m
04-05 01:44:24.268+0900 W/AUL     (30868): launch.c: app_request_to_launchpad(396) > request cmd(5) to(6417)
04-05 01:44:24.268+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 5
04-05 01:44:24.268+0900 E/AUL_AMD (  610): amd_request.c: __app_process_by_pid(272) > pid(6417) is dead. cmd(5) is canceled
04-05 01:44:24.268+0900 W/AUL     (30868): launch.c: app_request_to_launchpad(425) > request cmd(5) result(-3)
04-05 01:44:24.268+0900 E/PKGMGR_SERVER(30868): pkgmgr-server.c: __terminate_app(1401) > [0;31m[__terminate_app(): 1401](ret < 0) aul_terminate_pid[-3] fail
04-05 01:44:24.268+0900 E/PKGMGR_SERVER(30868): [0;m
04-05 01:44:24.268+0900 W/AUL     (30868): launch.c: app_request_to_launchpad(396) > request cmd(5) to(6686)
04-05 01:44:24.268+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 5
04-05 01:44:24.268+0900 E/AUL_AMD (  610): amd_request.c: __app_process_by_pid(272) > pid(6686) is dead. cmd(5) is canceled
04-05 01:44:24.268+0900 W/AUL     (30868): launch.c: app_request_to_launchpad(425) > request cmd(5) result(-3)
04-05 01:44:24.268+0900 E/PKGMGR_SERVER(30868): pkgmgr-server.c: __terminate_app(1401) > [0;31m[__terminate_app(): 1401](ret < 0) aul_terminate_pid[-3] fail
04-05 01:44:24.268+0900 E/PKGMGR_SERVER(30868): [0;m
04-05 01:44:24.268+0900 W/AUL     (30868): launch.c: app_request_to_launchpad(396) > request cmd(5) to(18306)
04-05 01:44:24.268+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 5
04-05 01:44:24.268+0900 E/AUL_AMD (  610): amd_request.c: __app_process_by_pid(272) > pid(18306) is dead. cmd(5) is canceled
04-05 01:44:24.268+0900 W/AUL     (30868): launch.c: app_request_to_launchpad(425) > request cmd(5) result(-3)
04-05 01:44:24.268+0900 E/PKGMGR_SERVER(30868): pkgmgr-server.c: __terminate_app(1401) > [0;31m[__terminate_app(): 1401](ret < 0) aul_terminate_pid[-3] fail
04-05 01:44:24.268+0900 E/PKGMGR_SERVER(30868): [0;m
04-05 01:44:24.268+0900 W/AUL     (30868): launch.c: app_request_to_launchpad(396) > request cmd(5) to(18430)
04-05 01:44:24.268+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 5
04-05 01:44:24.268+0900 E/AUL_AMD (  610): amd_request.c: __app_process_by_pid(272) > pid(18430) is dead. cmd(5) is canceled
04-05 01:44:24.268+0900 W/AUL     (30868): launch.c: app_request_to_launchpad(425) > request cmd(5) result(-3)
04-05 01:44:24.268+0900 E/PKGMGR_SERVER(30868): pkgmgr-server.c: __terminate_app(1401) > [0;31m[__terminate_app(): 1401](ret < 0) aul_terminate_pid[-3] fail
04-05 01:44:24.268+0900 E/PKGMGR_SERVER(30868): [0;m
04-05 01:44:24.268+0900 W/AUL     (30868): launch.c: app_request_to_launchpad(396) > request cmd(5) to(18553)
04-05 01:44:24.268+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 5
04-05 01:44:24.268+0900 E/AUL_AMD (  610): amd_request.c: __app_process_by_pid(272) > pid(18553) is dead. cmd(5) is canceled
04-05 01:44:24.268+0900 W/AUL     (30868): launch.c: app_request_to_launchpad(425) > request cmd(5) result(-3)
04-05 01:44:24.268+0900 E/PKGMGR_SERVER(30868): pkgmgr-server.c: __terminate_app(1401) > [0;31m[__terminate_app(): 1401](ret < 0) aul_terminate_pid[-3] fail
04-05 01:44:24.268+0900 E/PKGMGR_SERVER(30868): [0;m
04-05 01:44:24.268+0900 W/AUL     (30868): launch.c: app_request_to_launchpad(396) > request cmd(5) to(26716)
04-05 01:44:24.268+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 5
04-05 01:44:24.268+0900 E/AUL_AMD (  610): amd_request.c: __app_process_by_pid(272) > pid(26716) is dead. cmd(5) is canceled
04-05 01:44:24.268+0900 W/AUL     (30868): launch.c: app_request_to_launchpad(425) > request cmd(5) result(-3)
04-05 01:44:24.268+0900 E/PKGMGR_SERVER(30868): pkgmgr-server.c: __terminate_app(1401) > [0;31m[__terminate_app(): 1401](ret < 0) aul_terminate_pid[-3] fail
04-05 01:44:24.268+0900 E/PKGMGR_SERVER(30868): [0;m
04-05 01:44:24.268+0900 W/AUL     (30868): launch.c: app_request_to_launchpad(396) > request cmd(5) to(29758)
04-05 01:44:24.278+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 5
04-05 01:44:24.278+0900 E/AUL_AMD (  610): amd_request.c: __app_process_by_pid(272) > pid(29758) is dead. cmd(5) is canceled
04-05 01:44:24.278+0900 W/AUL     (30868): launch.c: app_request_to_launchpad(425) > request cmd(5) result(-3)
04-05 01:44:24.278+0900 E/PKGMGR_SERVER(30868): pkgmgr-server.c: __terminate_app(1401) > [0;31m[__terminate_app(): 1401](ret < 0) aul_terminate_pid[-3] fail
04-05 01:44:24.278+0900 E/PKGMGR_SERVER(30868): [0;m
04-05 01:44:24.278+0900 W/AUL     (30868): launch.c: app_request_to_launchpad(396) > request cmd(5) to(30557)
04-05 01:44:24.278+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 5
04-05 01:44:24.278+0900 I/APP_CORE(30557): appcore-efl.c: __do_app(514) > [APP 30557] Event: TERMINATE State: RUNNING
04-05 01:44:24.278+0900 W/AUL_AMD (  610): amd_launch.c: __reply_handler(1083) > listen fd(33) , send fd(32), pid(30557), cmd(4)
04-05 01:44:24.278+0900 W/AUL     (30868): launch.c: app_request_to_launchpad(425) > request cmd(5) result(0)
04-05 01:44:24.278+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 22
04-05 01:44:24.278+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(1201) > app status : 5
04-05 01:44:24.278+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 14
04-05 01:44:24.278+0900 W/AUL_AMD (  610): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: -1
04-05 01:44:24.278+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 22
04-05 01:44:24.278+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(1201) > app status : 5
04-05 01:44:24.288+0900 E/PKGMGR_SERVER(30865): pkgmgr-server.c: sighandler(417) > child NORMAL exit [30868]
04-05 01:44:24.288+0900 I/TIZEN_N_EFL_UTIL_WINDOW(30557): efl_util_window_dump.c: efl_util_capture_windows_in_buffer(832) > Windump Time = 12
04-05 01:44:24.288+0900 E/APP_CORE(30557): appcore-efl.c: _capture_and_make_file(1619) > win[7200002] widget[720] height[1280]
04-05 01:44:24.288+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 33
04-05 01:44:24.288+0900 E/APP_CORE(30557): appcore-efl.c: _capture_and_make_file(1622) > cannot a capture file for the package of [org.example.client]
04-05 01:44:24.298+0900 I/CAPI_APPFW_APPLICATION(30557): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
04-05 01:44:24.298+0900 I/CAPI_APPFW_APPLICATION(30557): app_main.c: _ui_app_appcore_terminate(663) > app_appcore_terminate
04-05 01:44:24.298+0900 E/EFL     (  351): eo<351> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-05 01:44:24.298+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(858) status(3)
04-05 01:44:24.298+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-05 01:44:24.298+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
04-05 01:44:24.298+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(858)
04-05 01:44:24.298+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 858, appid: com.samsung.homescreen, status: fg
04-05 01:44:24.328+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(858) status(0)
04-05 01:44:24.368+0900 I/APP_CORE(  858): appcore-efl.c: __do_app(514) > [APP 858] Event: RESUME State: PAUSED
04-05 01:44:24.368+0900 I/CAPI_APPFW_APPLICATION(  858): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-05 01:44:24.368+0900 E/cluster-home(  858): homescreen.cpp: OnResume(233) >  app resume
04-05 01:44:24.368+0900 E/EFL     (  351): eo<351> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-05 01:44:24.408+0900 I/Tizen::System( 1231): (259) > Active app [com.samsun], current [org.exampl] 
04-05 01:44:24.408+0900 E/weather-widget( 1448): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
04-05 01:44:24.428+0900 I/TIZEN_N_SOUND_MANAGER(  912): sound_manager.c: sound_manager_get_volume(84) > returns : type=0, volume=9, ret=0x0
04-05 01:44:24.428+0900 E/TIZEN_N_SOUND_MANAGER(  912): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
04-05 01:44:24.428+0900 I/Tizen::Io( 1231): (729) > Entry not found
04-05 01:44:24.438+0900 I/TIZEN_N_SOUND_MANAGER(  912): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=15, ret=0x0
04-05 01:44:24.438+0900 E/TIZEN_N_SOUND_MANAGER(  912): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
04-05 01:44:24.438+0900 E/weather-widget( 1448): WidgetView.cpp: Resume(456) > [0;40;31mNo need to Update[0;m
04-05 01:44:24.438+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
04-05 01:44:24.448+0900 I/Tizen::System( 1231): (157) > change brightness system value.
04-05 01:44:24.458+0900 E/weather-common( 1448): CityDBController.cpp: GetPageIndexOfCurrentCity(567) > [0;40;31mNo result : 101[0;m
04-05 01:44:24.468+0900 I/CAPI_NETWORK_CONNECTION( 1448): connection.c: connection_create(409) > New handle created[0xb7ab4a28]
04-05 01:44:24.468+0900 I/CAPI_NETWORK_CONNECTION( 1448): connection.c: connection_get_type(463) > Connected Network = 2
04-05 01:44:24.468+0900 I/CAPI_NETWORK_CONNECTION( 1448): connection.c: connection_destroy(427) > Destroy handle: 0xb7ab4a28
04-05 01:44:24.478+0900 E/weather-common( 1448): Network.cpp: IsNetworkAvailable(161) > [0;40;31mnetwork isAvailable:1[0;m
04-05 01:44:24.488+0900 E/weather-widget( 1448): WidgetMain.cpp: ResumeWidgetInstance(646) > [0;40;31mwe don't need to refresh[0;m
04-05 01:44:24.488+0900 I/CAPI_WIDGET_APPLICATION( 1448): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
04-05 01:44:24.488+0900 I/CAPI_WIDGET_APPLICATION( 1448): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
04-05 01:44:24.488+0900 W/AUL     ( 1448): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1448, appid: com.samsung.weather-m-widget, status: fg
04-05 01:44:24.648+0900 I/AUL_PAD ( 1673): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 30557 pgid = 30557
04-05 01:44:24.648+0900 I/AUL_PAD ( 1673): sigchild.h: __sigchild_action(143) > dead_pid(30557)
04-05 01:44:24.678+0900 I/AUL_PAD ( 1673): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
04-05 01:44:24.678+0900 I/AUL_PAD ( 1673): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
04-05 01:44:24.678+0900 E/AUL_PAD ( 1673): launchpad.c: main(698) > error reading sigchld info
04-05 01:44:24.678+0900 I/Tizen::App( 1231): (243) > App[org.example.client] pid[30557] terminate event is forwarded
04-05 01:44:24.678+0900 I/Tizen::System( 1231): (256) > osp.accessorymanager.service provider is found.
04-05 01:44:24.678+0900 I/Tizen::System( 1231): (196) > Accessory Owner is removed [org.example.client, 30557, ]
04-05 01:44:24.678+0900 I/Tizen::System( 1231): (256) > osp.system.service provider is found.
04-05 01:44:24.678+0900 I/Tizen::App( 1231): (506) > TerminatedApp(org.example.client)
04-05 01:44:24.678+0900 I/Tizen::App( 1231): (512) > Not registered pid(30557)
04-05 01:44:24.678+0900 I/Tizen::System( 1231): (246) > Terminated app [org.example.client]
04-05 01:44:24.678+0900 I/Tizen::Io( 1231): (729) > Entry not found
04-05 01:44:24.678+0900 I/ESD     (  893): esd_main.c: __esd_app_dead_handler(1773) > pid: 30557
04-05 01:44:24.688+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 30557
04-05 01:44:24.688+0900 E/RESOURCED(  664): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1688
04-05 01:44:24.698+0900 I/Tizen::System( 1231): (157) > change brightness system value.
04-05 01:44:24.698+0900 I/Tizen::App( 1231): (782) > Finished invoking application event listener for org.example.client, 30557.
04-05 01:44:26.640+0900 E/PKGMGR_SERVER(30865): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
04-05 01:44:26.640+0900 E/PKGMGR_SERVER(30865): pkgmgr-server.c: main(2471) > package manager server terminated.
04-05 01:44:28.141+0900 E/PKGMGR  (30957): pkgmgr.c: pkgmgr_client_reinstall(2020) > reinstall pkg start.
04-05 01:44:28.222+0900 E/PKGMGR_SERVER(30959): pkgmgr-server.c: main(2414) > package manager server start
04-05 01:44:28.262+0900 E/PKGMGR_SERVER(30959): pkgmgr-server-internal.c: _zone_set_type_and_backend(180) > tep_filepath [org.example.client]
04-05 01:44:28.272+0900 E/PKGMGR_SERVER(30959): pm-mdm.c: _get_package_info_from_file(116) > [0;31m[_get_package_info_from_file(): 116](ret < 0) access() failed. path: org.example.client errno: 2 (No such file or directory)[0;m
04-05 01:44:28.272+0900 E/PKGMGR  (30957): pkgmgr.c: pkgmgr_client_reinstall(2133) > reinstall pkg finish, ret=[309570002]
04-05 01:44:28.422+0900 I/Tizen::App( 1231): (1894) > PackageEventHandler - req: 12310002, pkg_type: tpk, pkg_name: org.example.client, key: start, val: update
04-05 01:44:28.422+0900 I/Tizen::App( 1231): (1584) > Package = [org.example.client], Key = [start], Value = [update], install = [1]
04-05 01:44:28.432+0900 W/AUL_AMD (  610): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(1068) > __amd_pkgmgrinfo_start_handler
04-05 01:44:28.432+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-05 01:44:28.432+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-05 01:44:28.432+0900 I/Tizen::App( 1231): (1894) > PackageEventHandler - req: 12310002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 30
04-05 01:44:28.432+0900 I/Tizen::App( 1231): (119) > InstallationInProgress [30]
04-05 01:44:28.432+0900 I/Tizen::App( 1231): (1584) > Package = [org.example.client], Key = [install_percent], Value = [30], install = [1]
04-05 01:44:28.432+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-05 01:44:28.432+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-05 01:44:28.572+0900 W/CERT_SVC_VCORE(30962): DUID.cpp: CheckCertifiedDevice(668) > No device id on distributor certificate
04-05 01:44:28.642+0900 E/rpm-installer(30962): coretpk-parser.c: _coretpk_parser_get_manifest_info(1183) > (doc == NULL) xmlParseFile() failed.
04-05 01:44:28.642+0900 E/rpm-installer(30962): coretpk-installer.c: _coretpk_installer_verify_privilege_list(1594) > (pkg_file_info == NULL) pkg_file_info is NULL.
04-05 01:44:28.702+0900 E/PKGMGR_PARSER(30962): pkgmgr_parser.c: __check_theme(154) > theme for uninstallation.
04-05 01:44:28.712+0900 I/PRIVACY-MANAGER-CLIENT(30962): SocketClient.cpp: SocketClient(37) > Client created
04-05 01:44:28.712+0900 I/PRIVACY-MANAGER-CLIENT(30962): SocketClient.cpp: connect(62) > Client connected
04-05 01:44:28.712+0900 I/PRIVACY-MANAGER-SERVER(  915): SocketService.cpp: mainloop(230) > Got incoming connection
04-05 01:44:28.722+0900 I/PRIVACY-MANAGER-CLIENT(30962): SocketClient.cpp: disconnect(72) > Client disconnected
04-05 01:44:28.722+0900 E/PKGMGR_CERT(30962): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(617) > Transaction Begin
04-05 01:44:28.722+0900 E/PKGMGR_CERT(30962): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(622) > Certificate Deletion Success
04-05 01:44:28.732+0900 E/PKGMGR_CERT(30962): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(635) > Transaction Commit and End
04-05 01:44:28.762+0900 E/rpm-installer(30962): coretpk-installer.c: _coretpk_installer_package_reinstall(6347) > _coretpk_installer_package_reinstall(org.example.client) failed.
04-05 01:44:28.772+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-05 01:44:28.772+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-05 01:44:28.772+0900 I/Tizen::App( 1231): (1894) > PackageEventHandler - req: 12310002, pkg_type: tpk, pkg_name: org.example.client, key: end, val: fail
04-05 01:44:28.772+0900 I/Tizen::App( 1231): (1584) > Package = [org.example.client], Key = [end], Value = [fail], install = [1]
04-05 01:44:28.772+0900 E/ESD     (  893): esd_main.c: __esd_pkgmgr_event_callback(1757) > pkg_event(3) falied
04-05 01:44:28.782+0900 W/AUL_AMD (  610): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(1111) > __amd_pkgmgrinfo_fail_handler
04-05 01:44:28.782+0900 W/ISF_PANEL_EFL(  788): isf_panel_efl.cpp: _isf_insert_ime_info_by_pkgid(1168) > pkgmgrinfo_pkginfo_get_pkginfo("org.example.client",~) returned -1
04-05 01:44:28.782+0900 W/ISF_PANEL_EFL(  788): isf_panel_efl.cpp: _package_manager_event_cb(1381) > isf_db_select_appids_by_pkgid returned 0.
04-05 01:44:29.283+0900 W/AUL_AMD (  610): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
04-05 01:44:29.283+0900 W/AUL_AMD (  610): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
04-05 01:44:30.434+0900 E/PKGMGR_SERVER(30959): pkgmgr-server.c: sighandler(417) > child NORMAL exit [30962]
04-05 01:44:30.634+0900 E/PKGMGR_SERVER(30959): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
04-05 01:44:30.634+0900 E/PKGMGR_SERVER(30959): pkgmgr-server.c: main(2471) > package manager server terminated.
04-05 01:44:31.214+0900 E/PKGMGR  (31012): pkgmgr.c: pkgmgr_client_install(1605) > install pkg start.
04-05 01:44:31.295+0900 E/PKGMGR_SERVER(31014): pkgmgr-server.c: main(2414) > package manager server start
04-05 01:44:31.335+0900 E/PKGMGR_SERVER(31014): pkgmgr-server-internal.c: _zone_set_type_and_backend(180) > tep_filepath [/opt/usr/apps/tmp/org.example.client-1.0.0-arm.tpk]
04-05 01:44:31.345+0900 E/PKGMGR_INFO(31014): pkgmgrinfo_pkginfo.c: pkgmgrinfo_pkginfo_get_unmounted_pkginfo(778) > (exist == 0) pkgid[/opt/usr/apps/tmp/org.example.client-1.0.0-arm.tpk] not found in DB
04-05 01:44:31.355+0900 E/rpm-installer(31014): librpm.c: __installer_util_delete_dir(171) > opendir(/tmp/coretpk-unzip) failed. [2][No such file or directory]
04-05 01:44:31.355+0900 E/PKGMGR_SERVER(31014): pm-mdm.c: _pm_check_mdm_policy(75) > [0;31m[_pm_check_mdm_policy(): 75](ret != MDM_RESULT_SUCCESS) can not connect mdm server[0;m
04-05 01:44:31.365+0900 E/PKGMGR  (31012): pkgmgr.c: pkgmgr_client_install(1723) > install pkg finish, ret=[310120002]
04-05 01:44:31.475+0900 E/PKGMGR_INSTALLER(31017): pkgmgr_installer.c: pkgmgr_installer_receive_request(225) > option is [i]
04-05 01:44:31.475+0900 E/rpm-installer(31017): rpm-appcore-intf.c: main(186) > [/opt/usr/apps/tmp/org.example.client-1.0.0-arm.tpk] is tpk package.
04-05 01:44:31.495+0900 E/rpm-installer(31017): coretpk-parser.c: _coretpk_parser_is_svc_app(1031) > (ret == 1) NodeSet is empty. (//*[name() = 'manifest']/*[name()='service-application'])
04-05 01:44:31.495+0900 E/rpm-installer(31017): coretpk-parser.c: __coretpk_parser_get_value(1147) > (result_value == NULL) [install-location] is empty.
04-05 01:44:31.495+0900 E/rpm-installer(31017): coretpk-parser.c: __coretpk_parser_is_theme(31) > (ret == 1) metadata(watchface) is empty.
04-05 01:44:31.495+0900 E/rpm-installer(31017): coretpk-parser.c: _coretpk_parser_is_widget(997) > (ret == 1) NodeSet is empty. (//*[name() = 'manifest']/*[name()='widget-application'])
04-05 01:44:31.495+0900 E/rpm-installer(31017): installer-util.c: _installer_util_get_configuration_value(565) > [signature]=[on]
04-05 01:44:31.555+0900 W/CERT_SVC_VCORE(31017): DUID.cpp: CheckCertifiedDevice(668) > No device id on distributor certificate
04-05 01:44:31.605+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-05 01:44:31.605+0900 I/Tizen::App( 1231): (1894) > PackageEventHandler - req: 12310002, pkg_type: tpk, pkg_name: org.example.client, key: start, val: install
04-05 01:44:31.605+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-05 01:44:31.605+0900 I/Tizen::App( 1231): (1584) > Package = [org.example.client], Key = [start], Value = [install], install = [1]
04-05 01:44:31.615+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-05 01:44:31.615+0900 I/Tizen::App( 1231): (1894) > PackageEventHandler - req: 12310002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 30
04-05 01:44:31.615+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-05 01:44:31.615+0900 I/Tizen::App( 1231): (119) > InstallationInProgress [30]
04-05 01:44:31.615+0900 I/Tizen::App( 1231): (1584) > Package = [org.example.client], Key = [install_percent], Value = [30], install = [1]
04-05 01:44:31.845+0900 E/rpm-installer(31017): coretpk-parser.c: __coretpk_parser_check_vip_tag(396) > (ret == 1) metadata(watchface) is empty.
04-05 01:44:31.845+0900 E/rpm-installer(31017): coretpk-parser.c: __coretpk_parser_get_value(1147) > (result_value == NULL) [ui-gadget] is empty.
04-05 01:44:31.845+0900 E/rpm-installer(31017): coretpk-parser.c: __coretpk_parser_append_path(335) > (ret == 1) NodeSet is empty. (//@portrait-effectimage)
04-05 01:44:31.845+0900 E/rpm-installer(31017): coretpk-parser.c: __coretpk_parser_is_theme(31) > (ret == 1) metadata(watchface) is empty.
04-05 01:44:31.845+0900 E/rpm-installer(31017): coretpk-parser.c: __coretpk_parser_allow_onboot(504) > (ret == 1) metadata is empty.
04-05 01:44:31.845+0900 E/rpm-installer(31017): coretpk-parser.c: __coretpk_parser_allow_autorestart(566) > (ret == 1) metadata is empty.
04-05 01:44:31.855+0900 E/PKGMGR_PARSER(31017): pkgmgr_parser.c: pkgmgr_parser_check_manifest_validation(2678) > Manifest is Valid
04-05 01:44:31.855+0900 E/PKGMGR_PARSER(31017): pkgmgr_parser_signature.c: __ps_check_mdm_policy(979) > (ret != MDM_RESULT_SUCCESS) can not connect mdm server
04-05 01:44:31.895+0900 I/PRIVACY-MANAGER-CLIENT(31017): SocketClient.cpp: SocketClient(37) > Client created
04-05 01:44:32.105+0900 E/PKGMGR_PARSER(31017): pkgmgr_parser.c: __check_theme(142) > theme for installation.
04-05 01:44:32.125+0900 E/PKGMGR_CERT(31017): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(427) > Transaction Begin
04-05 01:44:32.125+0900 E/PKGMGR_CERT(31017): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 1 109
04-05 01:44:32.125+0900 E/PKGMGR_CERT(31017): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 2 109
04-05 01:44:32.125+0900 E/PKGMGR_CERT(31017): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 41 3
04-05 01:44:32.125+0900 E/PKGMGR_CERT(31017): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 31 4
04-05 01:44:32.125+0900 E/PKGMGR_CERT(31017): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 32 4
04-05 01:44:32.125+0900 E/PKGMGR_CERT(31017): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 42 3
04-05 01:44:32.135+0900 E/PKGMGR_CERT(31017): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(576) > Transaction Commit and End
04-05 01:44:32.135+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-05 01:44:32.135+0900 I/Tizen::App( 1231): (1894) > PackageEventHandler - req: 12310002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 60
04-05 01:44:32.135+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-05 01:44:32.135+0900 I/Tizen::App( 1231): (119) > InstallationInProgress [60]
04-05 01:44:32.135+0900 I/Tizen::App( 1231): (1584) > Package = [org.example.client], Key = [install_percent], Value = [60], install = [1]
04-05 01:44:32.155+0900 E/rpm-installer(31017): installer-util.c: _installer_util_get_configuration_value(565) > [signature]=[on]
04-05 01:44:32.175+0900 E/rpm-installer(31017): coretpk-installer.c: __post_install_for_mmc(652) > (handle == NULL) handle is NULL.
04-05 01:44:32.175+0900 I/Tizen::App( 1231): (1894) > PackageEventHandler - req: 12310002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 100
04-05 01:44:32.175+0900 I/Tizen::App( 1231): (119) > InstallationInProgress [100]
04-05 01:44:32.175+0900 I/Tizen::App( 1231): (1584) > Package = [org.example.client], Key = [install_percent], Value = [100], install = [1]
04-05 01:44:32.175+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-05 01:44:32.175+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-05 01:44:33.637+0900 E/PKGMGR_SERVER(31014): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=0, queue_status=1, drm_status=1] 
04-05 01:44:34.077+0900 I/Tizen::App( 1231): (1894) > PackageEventHandler - req: 12310002, pkg_type: tpk, pkg_name: org.example.client, key: end, val: ok
04-05 01:44:34.077+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: OnClientListenCb(571) >  #Step 1
04-05 01:44:34.077+0900 I/Tizen::App( 1231): (78) > Installation is Completed. [Package = org.example.client]
04-05 01:44:34.077+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: OnClientListenCb(575) >  #Step 2
04-05 01:44:34.077+0900 I/Tizen::App( 1231): (671) > Enter. package(org.example.client), installationResult(0)
04-05 01:44:34.077+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: _GetAppIds(350) >  BEGIN
04-05 01:44:34.077+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-05 01:44:34.087+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-05 01:44:34.107+0900 W/ISF_PANEL_EFL(  788): isf_panel_efl.cpp: _package_manager_event_cb(1513) > _isf_insert_ime_info_by_pkgid returned 0.
04-05 01:44:34.107+0900 I/Tizen::App( 1231): (1360) > package(org.example.client), version(1.0.0), type(tpk), displayName(client), uninstallable(1), downloaded(1), updated(0), preloaded(0)movable(1), externalStorage(0), mainApp(org.example.client), storeClient(), appRootPath(/opt/usr/apps/org.example.client)
04-05 01:44:34.117+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(253) >  ##### [org.example.client]
04-05 01:44:34.117+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: _GetAppIds(375) >  ##### [org.example.client]
04-05 01:44:34.117+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: _GetAppIds(379) >  END
04-05 01:44:34.117+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: _DoPkgJob(458) >  #Step 3 size[1]
04-05 01:44:34.117+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: _DoPkgJob(462) >  appId[org.example.client]
04-05 01:44:34.117+0900 I/Tizen::App( 1231): (483) > pkgmgrinfo_appinfo_get_appid(): app = [org.example.client]
04-05 01:44:34.127+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: _GetAppInfo(990) >  Name[client] enable[1] system[0]
04-05 01:44:34.127+0900 E/HOME_APPS(  858): mainmenu-package-manager.cpp: _DoPkgJob(484) >  appId[org.example.client] mdm is not enabled
04-05 01:44:34.127+0900 I/Tizen::App( 1231): (416) > appName = [client]
04-05 01:44:34.127+0900 I/Tizen::App( 1231): (509) > exe = [/opt/usr/apps/org.example.client/bin/client], displayName = [client], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
04-05 01:44:34.127+0900 E/PKGMGR_INFO( 1231): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(887) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
04-05 01:44:34.127+0900 I/Tizen::App( 1231): (683) > Application count(1) in this package
04-05 01:44:34.137+0900 I/Tizen::App( 1231): (840) > Enter.
04-05 01:44:34.137+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: GetAppInfo(630) >  Find a App Info Name[client] enable[1] system[0]
04-05 01:44:34.137+0900 W/HOME_APPS(  858): mainmenu-box-impl.cpp: UpdateBoxData(1326) >  update box data!!!!! old icon path[/opt/usr/apps/org.example.client/shared/res/client.png], New icon path[/opt/usr/apps/org.example.client/shared/res/client.png]!!!!!
04-05 01:44:34.137+0900 I/Tizen::App( 1231): (416) > appName = [client]
04-05 01:44:34.137+0900 I/Tizen::App( 1231): (509) > exe = [/opt/usr/apps/org.example.client/bin/client], displayName = [client], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
04-05 01:44:34.137+0900 I/Tizen::App( 1231): (2343) > info file is not existed. [/opt/usr/apps/org.exampl/info/org.example.client.info]
04-05 01:44:34.147+0900 I/Tizen::App( 1231): (131) > Enter
04-05 01:44:34.147+0900 I/Tizen::App( 1231): (703) > Exit.
04-05 01:44:34.147+0900 I/Tizen::App( 1231): (1584) > Package = [org.example.client], Key = [end], Value = [ok], install = [96]
04-05 01:44:34.147+0900 I/Tizen::App( 1231): (137) > org.example.client does not have launch condition
04-05 01:44:34.147+0900 I/Tizen::App( 1231): (883) > Exit.
04-05 01:44:34.147+0900 E/util-view(  858): util-text-image-provider.cpp: GetPixelsFromText(240) >  DEFAULT='font=SamsungOneUI:style=Regular style=shadow,bottom shadow_color=# font_size=28 align=center valign=top color=#FFFFFF color_class=ATO001 text_class=ATO001 ellipsis=1 wrap=mixed linegap=-3'
04-05 01:44:34.167+0900 W/HOME_APPS(  858): mainmenu-box-impl.cpp: _OnImageLoadFinishedHandler(2152) >  finished path[/opt/usr/apps/org.example.client/shared/res/client.png], Loading state:[1]
04-05 01:44:34.227+0900 E/PKGMGR_SERVER(31014): pkgmgr-server.c: sighandler(417) > child NORMAL exit [31017]
04-05 01:44:35.639+0900 E/PKGMGR_SERVER(31014): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
04-05 01:44:35.639+0900 E/PKGMGR_SERVER(31014): pkgmgr-server.c: main(2471) > package manager server terminated.
04-05 01:44:38.241+0900 W/AUL     (31072): launch.c: app_request_to_launchpad(396) > request cmd(0) to(org.example.client)
04-05 01:44:38.241+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 0
04-05 01:44:38.251+0900 I/AUL     (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/launch_app, ret : 0
04-05 01:44:38.261+0900 I/AUL     (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /bin/bash, ret : 0
04-05 01:44:38.261+0900 E/AUL_AMD (  610): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
04-05 01:44:38.261+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(2508) > caller pid : 31072
04-05 01:44:38.261+0900 E/AUL_AMD (  610): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
04-05 01:44:38.271+0900 E/RESOURCED(  664): block.c: block_prelaunch_state(134) > insert data org.example.client, table num : 5
04-05 01:44:38.271+0900 E/RESOURCED(  664): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
04-05 01:44:38.271+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(3052) > pad pid(-5)
04-05 01:44:38.271+0900 W/AUL_PAD ( 1673): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
04-05 01:44:38.271+0900 W/AUL_PAD ( 1673): launchpad.c: __send_result_to_caller(267) > Check app launching
04-05 01:44:38.291+0900 I/abc     (30826): abc
04-05 01:44:38.291+0900 I/CAPI_APPFW_APPLICATION(30826): app_main.c: ui_app_main(789) > app_efl_main
04-05 01:44:38.291+0900 I/CAPI_APPFW_APPLICATION(30826): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
04-05 01:44:38.321+0900 E/TBM     (30826): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
04-05 01:44:38.371+0900 W/AUL     (  610): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 30826, appid: org.example.client
04-05 01:44:38.371+0900 E/AUL     (  610): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
04-05 01:44:38.371+0900 W/AUL     (31072): launch.c: app_request_to_launchpad(425) > request cmd(0) result(30826)
04-05 01:44:38.542+0900 D/basicui (30826): successed to load edc file
04-05 01:44:38.572+0900 E/EFL     (  351): eo<351> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-05 01:44:38.572+0900 E/EFL     (  351): eo<351> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-05 01:44:38.592+0900 I/Tizen::System( 1231): (259) > Active app [org.exampl], current [com.samsun] 
04-05 01:44:38.592+0900 I/Tizen::Io( 1231): (729) > Entry not found
04-05 01:44:38.602+0900 I/Tizen::System( 1231): (157) > change brightness system value.
04-05 01:44:38.612+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
04-05 01:44:38.672+0900 I/APP_CORE(30826): appcore-efl.c: __do_app(514) > [APP 30826] Event: RESET State: CREATED
04-05 01:44:38.672+0900 I/CAPI_APPFW_APPLICATION(30826): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
04-05 01:44:38.682+0900 E/EFL     (30826): edje<30826> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-05 01:44:38.682+0900 E/EFL     (30826): By the power of Grayskull, your previous Embryo stack is now broken!
04-05 01:44:38.692+0900 E/EFL     (30826): edje<30826> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-05 01:44:38.692+0900 E/EFL     (30826): By the power of Grayskull, your previous Embryo stack is now broken!
04-05 01:44:38.692+0900 E/EFL     (30826): edje<30826> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-05 01:44:38.692+0900 E/EFL     (30826): By the power of Grayskull, your previous Embryo stack is now broken!
04-05 01:44:38.702+0900 W/APP_CORE(30826): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:5800002
04-05 01:44:38.702+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 35
04-05 01:44:38.802+0900 I/APP_CORE(  858): appcore-efl.c: __do_app(514) > [APP 858] Event: PAUSE State: RUNNING
04-05 01:44:38.802+0900 I/CAPI_APPFW_APPLICATION(  858): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
04-05 01:44:38.802+0900 I/APP_CORE(30826): appcore-efl.c: __do_app(514) > [APP 30826] Event: RESUME State: CREATED
04-05 01:44:38.802+0900 E/cluster-home(  858): homescreen.cpp: OnPause(260) >  app pause
04-05 01:44:38.802+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(858) status(4)
04-05 01:44:38.802+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(858)
04-05 01:44:38.802+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 858, appid: com.samsung.homescreen, status: bg
04-05 01:44:38.812+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(30826) status(3)
04-05 01:44:38.812+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-05 01:44:38.812+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
04-05 01:44:38.812+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.client(30826)
04-05 01:44:38.812+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 30826, appid: org.example.client, status: fg
04-05 01:44:38.822+0900 I/CAPI_WIDGET_APPLICATION( 1448): widget_app.c: __provider_pause_cb(304) > widget obj was paused
04-05 01:44:38.822+0900 I/CAPI_WIDGET_APPLICATION( 1448): widget_app.c: __check_status_for_cgroup(152) > enter background group
04-05 01:44:38.822+0900 W/AUL     ( 1448): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1448, appid: com.samsung.weather-m-widget, status: bg
04-05 01:44:38.822+0900 I/APP_CORE(30826): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
04-05 01:44:38.822+0900 I/APP_CORE(30826): appcore-efl.c: __do_app(625) > [APP 30826] Initial Launching, call the resume_cb
04-05 01:44:38.822+0900 I/CAPI_APPFW_APPLICATION(30826): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-05 01:44:39.162+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(30826) status(0)
04-05 01:44:39.433+0900 E/RESOURCED(  664): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1698
04-05 01:44:39.443+0900 I/Tizen::App( 1231): (499) > LaunchedApp(org.example.client)
04-05 01:44:39.443+0900 I/Tizen::App( 1231): (733) > Finished invoking application event listener for org.example.client, 30826.
04-05 01:44:40.213+0900 I/UXT     (31085): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
04-05 01:44:43.797+0900 I/APP_CORE(  858): appcore-efl.c: __do_app(514) > [APP 858] Event: MEM_FLUSH State: PAUSED
04-05 01:44:55.658+0900 E/EFL     (30826): ecore_x<30826> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=122215021
04-05 01:44:55.748+0900 E/EFL     (30826): ecore_x<30826> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=122215108
04-05 01:44:55.969+0900 E/EFL     (  351): eo<351> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-05 01:44:55.969+0900 I/AUL_PAD ( 1673): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 30826 pgid = 30826
04-05 01:44:55.969+0900 I/AUL_PAD ( 1673): sigchild.h: __sigchild_action(143) > dead_pid(30826)
04-05 01:44:55.979+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(858) status(3)
04-05 01:44:55.979+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-05 01:44:55.979+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
04-05 01:44:55.979+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(858)
04-05 01:44:55.979+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 858, appid: com.samsung.homescreen, status: fg
04-05 01:44:56.009+0900 I/AUL_PAD ( 1673): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
04-05 01:44:56.009+0900 I/AUL_PAD ( 1673): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
04-05 01:44:56.009+0900 E/AUL_PAD ( 1673): launchpad.c: main(698) > error reading sigchld info
04-05 01:44:56.019+0900 I/Tizen::App( 1231): (243) > App[org.example.client] pid[30826] terminate event is forwarded
04-05 01:44:56.019+0900 I/Tizen::System( 1231): (256) > osp.accessorymanager.service provider is found.
04-05 01:44:56.019+0900 I/Tizen::System( 1231): (196) > Accessory Owner is removed [org.example.client, 30826, ]
04-05 01:44:56.019+0900 I/Tizen::System( 1231): (256) > osp.system.service provider is found.
04-05 01:44:56.019+0900 I/Tizen::App( 1231): (506) > TerminatedApp(org.example.client)
04-05 01:44:56.019+0900 I/Tizen::App( 1231): (512) > Not registered pid(30826)
04-05 01:44:56.019+0900 I/Tizen::System( 1231): (246) > Terminated app [org.example.client]
04-05 01:44:56.019+0900 I/Tizen::Io( 1231): (729) > Entry not found
04-05 01:44:56.019+0900 I/ESD     (  893): esd_main.c: __esd_app_dead_handler(1773) > pid: 30826
04-05 01:44:56.019+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 30826
04-05 01:44:56.019+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 30826
04-05 01:44:56.029+0900 E/RESOURCED(  664): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1701
04-05 01:44:56.039+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(858) status(0)
04-05 01:44:56.039+0900 I/Tizen::System( 1231): (157) > change brightness system value.
04-05 01:44:56.039+0900 I/Tizen::App( 1231): (782) > Finished invoking application event listener for org.example.client, 30826.
04-05 01:44:56.069+0900 I/APP_CORE(  858): appcore-efl.c: __do_app(514) > [APP 858] Event: RESUME State: PAUSED
04-05 01:44:56.069+0900 I/CAPI_APPFW_APPLICATION(  858): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-05 01:44:56.069+0900 E/cluster-home(  858): homescreen.cpp: OnResume(233) >  app resume
04-05 01:44:56.069+0900 E/EFL     (  351): eo<351> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-05 01:44:56.079+0900 E/weather-widget( 1448): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
04-05 01:44:56.099+0900 W/CRASH_MANAGER(31092): worker.c: worker_job(1199) > 1130826636c69149132429
