S/W Version Information
Model: SM-Z300H
Tizen-Version: 2.4.0.3
Build-Number: Z300HDDU0BPI2
Build-Date: 2016.09.30 15:37:12

Crash Information
Process Name: client
PID: 15731
Date: 2017-06-13 14:01:56+0900
Executable File Path: /opt/usr/apps/org.example.client/bin/client
Signal: 4
      (SIGILL)
      si_code: 1
      illegal opcode
      si_addr: 0xb278765a

Register Information
r0   = 0xb828d9a8, r1   = 0xb82898e0
r2   = 0xb82898e0, r3   = 0xb828d9a8
r4   = 0xb3f76a3c, r5   = 0xbed25484
r6   = 0x00000001, r7   = 0xbed25348
r8   = 0xbed25478, r9   = 0xb80b89e0
r10  = 0xbed25498, fp   = 0x00000004
ip   = 0x00000000, sp   = 0xbed252ec
lr   = 0xb27875d7, pc   = 0xb278765a
cpsr = 0x40070030

Memory Information
MemTotal:   987012 KB
MemFree:     74056 KB
Buffers:     61820 KB
Cached:     225904 KB
VmPeak:      90468 KB
VmSize:      90464 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       19544 KB
VmRSS:       19544 KB
VmData:      22012 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       35772 KB
VmPTE:          70 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 15731 TID = 15731
15731 15735 16010 

Maps Information
b1b38000 b1b40000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b1b51000 b1b52000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b1b62000 b1b76000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b1b8a000 b1b8b000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b1b9b000 b1b9e000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b1baf000 b1bb0000 r-xp /usr/lib/libxshmfence.so.1.0.0
b1bc0000 b1bc2000 r-xp /usr/lib/libxcb-present.so.0.0.0
b1bd2000 b1bd4000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b1be4000 b1bf4000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b1c04000 b1c10000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b1c22000 b2421000 rw-p [stack:16010]
b2752000 b2759000 r-xp /usr/lib/libefl-extension.so.0.1.0
b276c000 b2772000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b2782000 b27b2000 r-xp /opt/usr/apps/org.example.client/bin/client
b28fb000 b29de000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2a15000 b2a3d000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2a4f000 b324e000 rw-p [stack:15735]
b324e000 b3250000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b3260000 b326a000 r-xp /lib/libnss_files-2.20-2014.11.so
b327b000 b3284000 r-xp /lib/libnss_nis-2.20-2014.11.so
b3295000 b32a6000 r-xp /lib/libnsl-2.20-2014.11.so
b32b9000 b32bf000 r-xp /lib/libnss_compat-2.20-2014.11.so
b32d0000 b32d1000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b32f9000 b3300000 r-xp /usr/lib/libminizip.so.1.0.0
b3310000 b3315000 r-xp /usr/lib/libstorage.so.0.1
b3325000 b3384000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b339a000 b33ae000 r-xp /usr/lib/libcapi-media-camera.so.0.1.90
b33be000 b3402000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b3412000 b341a000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b342a000 b345a000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b346d000 b3526000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b353a000 b358d000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b359e000 b35b9000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b35c9000 b368a000 r-xp /usr/lib/libprotobuf.so.9.0.1
b369d000 b36ad000 r-xp /usr/lib/libefl-assist.so.0.1.0
b36bd000 b36ca000 r-xp /usr/lib/libmdm-common.so.1.0.98
b36db000 b36e2000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b36f2000 b3733000 r-xp /usr/lib/libmdm.so.1.2.12
b3743000 b374b000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b375a000 b376a000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b378b000 b37eb000 r-xp /usr/lib/libasound.so.2.0.0
b37fd000 b3800000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b3810000 b3813000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b3823000 b3828000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b3838000 b3839000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b3849000 b3854000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b3868000 b386f000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b387f000 b3885000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b3895000 b389a000 r-xp /usr/lib/libmmfsession.so.0.0.1
b38aa000 b38c5000 r-xp /usr/lib/libmmfsound.so.0.1.0
b38d5000 b38dc000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b38ec000 b38ef000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b3900000 b392e000 r-xp /usr/lib/libidn.so.11.5.44
b393e000 b3954000 r-xp /usr/lib/libnghttp2.so.5.4.0
b3965000 b396f000 r-xp /usr/lib/libcares.so.2.1.0
b397f000 b3989000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.32
b3999000 b399b000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.18
b39ab000 b39ac000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b39bc000 b39c0000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b39d1000 b39f9000 r-xp /usr/lib/libui-extension.so.0.1.0
b3a0a000 b3a33000 r-xp /usr/lib/libturbojpeg.so
b3a53000 b3a59000 r-xp /usr/lib/libgif.so.4.1.6
b3a69000 b3aaf000 r-xp /usr/lib/libcurl.so.4.3.0
b3ac0000 b3ae1000 r-xp /usr/lib/libexif.so.12.3.3
b3afc000 b3b11000 r-xp /usr/lib/libtts.so
b3b22000 b3b2a000 r-xp /usr/lib/libfeedback.so.0.1.4
b3b3a000 b3c00000 r-xp /usr/lib/libdali-core.so.0.0.0
b3c20000 b3d18000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b3d37000 b3e05000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b3e1c000 b3e1e000 r-xp /usr/lib/libboost_system.so.1.51.0
b3e2e000 b3e34000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b3e44000 b3e67000 r-xp /usr/lib/libboost_thread.so.1.51.0
b3e78000 b3e7a000 r-xp /usr/lib/libappsvc.so.0.1.0
b3e8a000 b3e8c000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b3e9d000 b3ea2000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b3eb9000 b3ebb000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b3ecb000 b3ed2000 r-xp /usr/lib/libsensord-share.so
b3ee2000 b3efa000 r-xp /usr/lib/libsensor.so.1.1.0
b3f0b000 b3f0e000 r-xp /usr/lib/libXv.so.1.0.0
b3f1e000 b3f23000 r-xp /usr/lib/libutilX.so.1.1.0
b3f33000 b3f38000 r-xp /usr/lib/libappcore-common.so.1.1
b3f48000 b3f4f000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.11
b3f62000 b3f66000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b3f77000 b4055000 r-xp /usr/lib/libCOREGL.so.4.0
b4075000 b4078000 r-xp /usr/lib/libuuid.so.1.3.0
b4088000 b409f000 r-xp /usr/lib/libblkid.so.1.1.0
b40b0000 b40b2000 r-xp /usr/lib/libXau.so.6.0.0
b40c2000 b4109000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b411b000 b4121000 r-xp /usr/lib/libjson-c.so.2.0.1
b4132000 b4136000 r-xp /usr/lib/libogg.so.0.7.1
b4146000 b4168000 r-xp /usr/lib/libvorbis.so.0.4.3
b4178000 b425c000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b4278000 b427b000 r-xp /usr/lib/libEGL.so.1.4
b428c000 b4292000 r-xp /usr/lib/libxcb-render.so.0.0.0
b42a2000 b42a4000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b42b4000 b42c1000 r-xp /usr/lib/libGLESv2.so.2.0
b42d2000 b4334000 r-xp /usr/lib/libpixman-1.so.0.28.2
b4349000 b4361000 r-xp /usr/lib/libmount.so.1.1.0
b4373000 b4387000 r-xp /usr/lib/libxcb.so.1.1.0
b4397000 b439e000 r-xp /lib/libcrypt-2.20-2014.11.so
b43d6000 b43d8000 r-xp /usr/lib/libiri.so
b43e8000 b43f3000 r-xp /usr/lib/libgpg-error.so.0.15.0
b4404000 b443a000 r-xp /usr/lib/libpulse.so.0.16.2
b444b000 b448e000 r-xp /usr/lib/libsndfile.so.1.0.25
b44a3000 b44b8000 r-xp /lib/libexpat.so.1.5.2
b44ca000 b4588000 r-xp /usr/lib/libcairo.so.2.11200.14
b459c000 b45a4000 r-xp /usr/lib/libdrm.so.2.4.0
b45b4000 b45b7000 r-xp /usr/lib/libdri2.so.0.0.0
b45c7000 b4615000 r-xp /usr/lib/libssl.so.1.0.0
b462a000 b4636000 r-xp /usr/lib/libeeze.so.1.13.0
b4647000 b4650000 r-xp /usr/lib/libethumb.so.1.13.0
b4660000 b4663000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b4673000 b482a000 r-xp /usr/lib/libcrypto.so.1.0.0
b5615000 b561e000 r-xp /usr/lib/libXi.so.6.1.0
b562e000 b5630000 r-xp /usr/lib/libXgesture.so.7.0.0
b5640000 b5644000 r-xp /usr/lib/libXtst.so.6.1.0
b5654000 b565a000 r-xp /usr/lib/libXrender.so.1.3.0
b566a000 b5670000 r-xp /usr/lib/libXrandr.so.2.2.0
b5680000 b5682000 r-xp /usr/lib/libXinerama.so.1.0.0
b5693000 b5696000 r-xp /usr/lib/libXfixes.so.3.1.0
b56a6000 b56b1000 r-xp /usr/lib/libXext.so.6.4.0
b56c1000 b56c3000 r-xp /usr/lib/libXdamage.so.1.1.0
b56d3000 b56d5000 r-xp /usr/lib/libXcomposite.so.1.0.0
b56e5000 b57c7000 r-xp /usr/lib/libX11.so.6.3.0
b57db000 b57e2000 r-xp /usr/lib/libXcursor.so.1.0.2
b57f2000 b580a000 r-xp /usr/lib/libudev.so.1.6.0
b580c000 b580f000 r-xp /lib/libattr.so.1.1.0
b581f000 b583f000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5840000 b5845000 r-xp /usr/lib/libffi.so.6.0.2
b5856000 b586e000 r-xp /lib/libz.so.1.2.8
b587e000 b5880000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b5890000 b5965000 r-xp /usr/lib/libxml2.so.2.9.2
b597a000 b5a15000 r-xp /usr/lib/libstdc++.so.6.0.20
b5a31000 b5a34000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5a44000 b5a5d000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5a6e000 b5a7f000 r-xp /lib/libresolv-2.20-2014.11.so
b5a93000 b5b0d000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5b22000 b5b24000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5b34000 b5b3b000 r-xp /usr/lib/libembryo.so.1.13.0
b5b4b000 b5b55000 r-xp /usr/lib/libecore_audio.so.1.13.0
b5b66000 b5b7e000 r-xp /usr/lib/libpng12.so.0.50.0
b5b8f000 b5bb2000 r-xp /usr/lib/libjpeg.so.8.0.2
b5bd3000 b5be7000 r-xp /usr/lib/libector.so.1.13.0
b5bf8000 b5c10000 r-xp /usr/lib/liblua-5.1.so
b5c21000 b5c78000 r-xp /usr/lib/libfreetype.so.6.11.3
b5c8c000 b5cb4000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5cc5000 b5cd8000 r-xp /usr/lib/libfribidi.so.0.3.1
b5ce9000 b5d23000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5d34000 b5d42000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5d52000 b5d5a000 r-xp /usr/lib/libtbm.so.1.0.0
b5d6a000 b5d77000 r-xp /usr/lib/libeio.so.1.13.0
b5d87000 b5d89000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5d99000 b5d9e000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5dae000 b5dc5000 r-xp /usr/lib/libefreet.so.1.13.0
b5dd7000 b5df7000 r-xp /usr/lib/libeldbus.so.1.13.0
b5e07000 b5e27000 r-xp /usr/lib/libecore_con.so.1.13.0
b5e29000 b5e2f000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5e3f000 b5e50000 r-xp /usr/lib/libemotion.so.1.13.0
b5e61000 b5e68000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5e78000 b5e87000 r-xp /usr/lib/libeo.so.1.13.0
b5e98000 b5eaa000 r-xp /usr/lib/libecore_input.so.1.13.0
b5ebb000 b5ec0000 r-xp /usr/lib/libecore_file.so.1.13.0
b5ed0000 b5ee9000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5ef9000 b5f16000 r-xp /usr/lib/libeet.so.1.13.0
b5f2f000 b5f77000 r-xp /usr/lib/libeina.so.1.13.0
b5f88000 b5f98000 r-xp /usr/lib/libefl.so.1.13.0
b5fa9000 b608e000 r-xp /usr/lib/libicuuc.so.51.1
b60ab000 b61eb000 r-xp /usr/lib/libicui18n.so.51.1
b6202000 b623a000 r-xp /usr/lib/libecore_x.so.1.13.0
b624c000 b624f000 r-xp /lib/libcap.so.2.21
b625f000 b6288000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b6299000 b62a0000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b62b2000 b62e9000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b62fa000 b63e5000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b63f8000 b6471000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6483000 b6488000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b6498000 b64a2000 r-xp /usr/lib/libvconf.so.0.2.45
b64b2000 b64b4000 r-xp /usr/lib/libvasum.so.0.3.1
b64c4000 b64c6000 r-xp /usr/lib/libttrace.so.1.1
b64d6000 b64d9000 r-xp /usr/lib/libiniparser.so.0
b64e9000 b650f000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b651f000 b6524000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6535000 b654c000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b655d000 b65c8000 r-xp /lib/libm-2.20-2014.11.so
b65d9000 b65df000 r-xp /lib/librt-2.20-2014.11.so
b65f0000 b65fd000 r-xp /usr/lib/libunwind.so.8.0.1
b6633000 b6757000 r-xp /lib/libc-2.20-2014.11.so
b676c000 b6785000 r-xp /lib/libgcc_s-4.9.so.1
b6795000 b6877000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b6888000 b68b2000 r-xp /usr/lib/libdbus-1.so.3.8.12
b68c3000 b68ff000 r-xp /usr/lib/libsystemd.so.0.4.0
b6901000 b6984000 r-xp /usr/lib/libedje.so.1.13.0
b6997000 b69b5000 r-xp /usr/lib/libecore.so.1.13.0
b69d5000 b6b5c000 r-xp /usr/lib/libevas.so.1.13.0
b6b91000 b6ba5000 r-xp /lib/libpthread-2.20-2014.11.so
b6bb9000 b6ded000 r-xp /usr/lib/libelementary.so.1.13.0
b6e1c000 b6e20000 r-xp /usr/lib/libsmack.so.1.0.0
b6e30000 b6e37000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6e47000 b6e49000 r-xp /usr/lib/libdlog.so.0.0.0
b6e59000 b6e5c000 r-xp /usr/lib/libbundle.so.0.1.22
b6e6c000 b6e6e000 r-xp /lib/libdl-2.20-2014.11.so
b6e7f000 b6e97000 r-xp /usr/lib/libaul.so.0.1.0
b6eab000 b6eb0000 r-xp /usr/lib/libappcore-efl.so.1.1
b6ec1000 b6ece000 r-xp /usr/lib/liblptcp.so
b6ee0000 b6ee4000 r-xp /usr/lib/libsys-assert.so
b6ef5000 b6f15000 r-xp /lib/ld-2.20-2014.11.so
b6f26000 b6f2b000 r-xp /usr/bin/launchpad-loader
b8075000 b82ba000 rw-p [heap]
bed05000 bed26000 rw-p [stack]
End of Maps Information

Callstack Information (PID:15731)
Call Stack Count: 13
 0: $d.51 + 0x0 (0xb278765a) [/opt/usr/apps/org.example.client/bin/client] + 0x565a
 1: _ZN7MyLoginC2EP9Naviframe + 0x86 (0xb27875d7) [/opt/usr/apps/org.example.client/bin/client] + 0x55d7
 2: _ZN8MyWindow8onCreateEv + 0x118 (0xb27873a9) [/opt/usr/apps/org.example.client/bin/client] + 0x53a9
 3: _ZN6Window10app_createEPv + 0x72 (0xb27a05db) [/opt/usr/apps/org.example.client/bin/client] + 0x1e5db
 4: _ZN6Window17static_app_createEPv + 0x24 (0xb27a0751) [/opt/usr/apps/org.example.client/bin/client] + 0x1e751
 5: (0xb3f644f9) [/usr/lib/libcapi-appfw-application.so.0] + 0x24f9
 6: appcore_efl_main + 0x152 (0xb6eae203) [/usr/lib/libappcore-efl.so.1] + 0x3203
 7: ui_app_main + 0xc0 (0xb3f64909) [/usr/lib/libcapi-appfw-application.so.0] + 0x2909
 8: _ZN6Window10makeWindowEiPPc + 0x11e (0xb27a0adb) [/opt/usr/apps/org.example.client/bin/client] + 0x1eadb
 9: main + 0x40 (0xb2787129) [/opt/usr/apps/org.example.client/bin/client] + 0x5129
10: (0xb6f27bb5) [/opt/usr/apps/org.example.client/bin/client] + 0x1bb5
11: __libc_start_main + 0x114 (0xb66494bc) [/lib/libc.so.6] + 0x164bc
12: (0xb6f27eb4) [/opt/usr/apps/org.example.client/bin/client] + 0x1eb4
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
): (256) > osp.accessorymanager.service provider is found.
06-13 14:01:37.652+0900 I/Tizen::System( 1175): (196) > Accessory Owner is removed [org.example.client, 15415, ]
06-13 14:01:37.652+0900 I/Tizen::System( 1175): (256) > osp.system.service provider is found.
06-13 14:01:37.652+0900 I/Tizen::App( 1175): (506) > TerminatedApp(org.example.client)
06-13 14:01:37.652+0900 I/Tizen::App( 1175): (512) > Not registered pid(15415)
06-13 14:01:37.652+0900 I/Tizen::System( 1175): (246) > Terminated app [org.example.client]
06-13 14:01:37.652+0900 I/Tizen::Io( 1175): (729) > Entry not found
06-13 14:01:37.652+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=17083859
06-13 14:01:37.652+0900 W/STARTER (  721): hw_key.c: _key_press_cb(758) > [_key_press_cb:758] Home Key is pressed
06-13 14:01:37.652+0900 E/cluster-view( 1167): homescreen-view-manager.cpp: _OnKeyEvent(1048) >  receive[XF86Home]Key [Down]Event!! 
06-13 14:01:37.652+0900 I/ESD     (  898): esd_main.c: __esd_app_dead_handler(1773) > pid: 15415
06-13 14:01:37.652+0900 E/EFL     (  857): ecore_x<857> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=17083859
06-13 14:01:37.652+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 15415
06-13 14:01:37.652+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 15415
06-13 14:01:37.652+0900 W/STARTER (  721): hw_key.c: _key_press_cb(776) > [_key_press_cb:776] homekey count : 1
06-13 14:01:37.662+0900 E/RESOURCED(  667): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1589
06-13 14:01:37.672+0900 I/Tizen::System( 1175): (157) > change brightness system value.
06-13 14:01:37.672+0900 I/Tizen::App( 1175): (782) > Finished invoking application event listener for org.example.client, 15415.
06-13 14:01:37.952+0900 I/SYSPOPUP(  859): syspopup.c: __X_syspopup_term_handler(98) > enter syspopup term handler
06-13 14:01:37.962+0900 I/SYSPOPUP(  859): syspopup.c: __X_syspopup_term_handler(108) > term action 1 - volume
06-13 14:01:37.962+0900 E/VOLUME  (  859): volume_x_event.c: volume_x_input_event_unregister(354) > [volume_x_input_event_unregister:354] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
06-13 14:01:37.962+0900 E/VOLUME  (  859): volume_control.c: volume_control_close(841) > [volume_control_close:841] Failed to unregister x input event handler
06-13 14:01:37.962+0900 E/STARTER (  721): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(355) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:355:E] dbus_connection_send error(No reply)
06-13 14:01:37.962+0900 E/STARTER (  721): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(359) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:359:E] dbus_connection_send error(org.freedesktop.DBus.Error.UnknownMethod:Method "getstatus" with signature "" on interface "org.tizen.system.deviced.hall" doesn't exist
06-13 14:01:37.962+0900 E/STARTER (  721): )
06-13 14:01:37.972+0900 W/AUL     (  721): launch.c: app_request_to_launchpad(396) > request cmd(0) to(com.samsung.task-mgr)
06-13 14:01:37.972+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 0
06-13 14:01:37.992+0900 I/AUL     (  607): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/starter, ret : 0
06-13 14:01:37.992+0900 E/AUL_AMD (  607): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
06-13 14:01:37.992+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(2508) > caller pid : 721
06-13 14:01:37.992+0900 E/AUL_AMD (  607): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
06-13 14:01:38.002+0900 E/RESOURCED(  667): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-13 14:01:38.012+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(3052) > pad pid(-5)
06-13 14:01:38.012+0900 W/AUL_PAD ( 1377): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
06-13 14:01:38.012+0900 W/AUL_PAD ( 1377): launchpad.c: __send_result_to_caller(267) > Check app launching
06-13 14:01:38.032+0900 I/GXT_SIB (  342): gxt_shared_image_buffer.c: gxt_shared_image_buffer_initialize(113) > [Shared Image Buffer] flink_id=5
06-13 14:01:38.042+0900 E/CAPI_APPFW_APPLICATION(15431): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
06-13 14:01:38.042+0900 E/CAPI_APPFW_APPLICATION(15431): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
06-13 14:01:38.042+0900 E/CAPI_APPFW_APPLICATION(15431): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
06-13 14:01:38.042+0900 E/CAPI_APPFW_APPLICATION(15431): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
06-13 14:01:38.042+0900 E/CAPI_APPFW_APPLICATION(15431): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
06-13 14:01:38.042+0900 I/CAPI_APPFW_APPLICATION(15431): app_main.c: ui_app_main(789) > app_efl_main
06-13 14:01:38.042+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:783 _eo_api_op_id_get() in elm_layout.eo.c:34: unable to resolve regular api func 'elm_obj_layout_edje_get' 0xb6bdc6e9 in class 'Edje_Object'.
06-13 14:01:38.042+0900 I/CAPI_APPFW_APPLICATION(15431): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
06-13 14:01:38.042+0900 E/UXT     (  342): uxt_theme_object.c: uxt_theme_object_set_changeable_ui_enabled(42) > failed to get edje from parent object.
06-13 14:01:38.112+0900 W/AUL     (  607): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 15431, appid: com.samsung.task-mgr
06-13 14:01:38.112+0900 E/AUL     (  607): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
06-13 14:01:38.112+0900 E/RESOURCED(  667): proc-main.c: proc_add_program_list(237) > not found ppi : com.samsung.task-mgr
06-13 14:01:38.122+0900 W/AUL     (  721): launch.c: app_request_to_launchpad(425) > request cmd(0) result(15431)
06-13 14:01:38.152+0900 E/EFL     (  342): evas-gl_x11<342> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
06-13 14:01:38.162+0900 E/EFL     (  342): evas-gl_x11<342> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
06-13 14:01:38.193+0900 E/EFL     (  342): evas-gl_x11<342> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
06-13 14:01:38.203+0900 E/EFL     (  342): evas-gl_x11<342> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
06-13 14:01:38.223+0900 E/EFL     (  342): evas-gl_x11<342> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
06-13 14:01:38.233+0900 E/EFL     (  342): evas-gl_x11<342> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
06-13 14:01:38.243+0900 W/TASK_MGR_LITE(15431): task-mgr-lite.c: create_win(197) > changeable ui enabled success
06-13 14:01:38.243+0900 I/GXT_SIB (15431): gxt_shared_image_buffer.c: gxt_shared_image_buffer_initialize(113) > [Shared Image Buffer] flink_id=5
06-13 14:01:38.283+0900 E/EFL     (  342): evas-gl_x11<342> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
06-13 14:01:38.313+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 12
06-13 14:01:38.313+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-13 14:01:38.313+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-13 14:01:38.313+0900 E/RUA     (15431): rua.c: rua_history_load_db(278) > rua_history_load_db ok. nrows : 24, ncols : 5
06-13 14:01:38.313+0900 E/TASK_MGR_LITE(15431): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.weather-m-agent) in ai_tbl !!
06-13 14:01:38.313+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 14
06-13 14:01:38.323+0900 E/EFL     (  342): evas-gl_x11<342> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
06-13 14:01:38.323+0900 W/AUL_AMD (  607): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: -1
06-13 14:01:38.323+0900 E/TASK_MGR_LITE(15431): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.task-mgr) in ai_tbl !!
06-13 14:01:38.323+0900 E/TASK_MGR_LITE(15431): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.homescreen) in ai_tbl !!
06-13 14:01:38.323+0900 E/TASK_MGR_LITE(15431): recent_apps.c: list_retrieve_item(263) > Can't find app (org.tizen.tizenstoreservice) in ai_tbl !!
06-13 14:01:38.323+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 15
06-13 14:01:38.323+0900 E/TASK_MGR_LITE(15431): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.image-viewer-subapp-single) in ai_tbl !!
06-13 14:01:38.323+0900 E/TASK_MGR_LITE(15431): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.sdbd-syspopup) in ai_tbl !!
06-13 14:01:38.323+0900 E/TASK_MGR_LITE(15431): recent_apps.c: list_retrieve_item(263) > Can't find app (org.tizen.poweroff-syspopup) in ai_tbl !!
06-13 14:01:38.323+0900 E/TASK_MGR_LITE(15431): recent_apps.c: list_retrieve_item(263) > Can't find app (net.netpopup) in ai_tbl !!
06-13 14:01:38.323+0900 E/TASK_MGR_LITE(15431): recent_apps.c: list_retrieve_item(263) > Can't find app (org.tizen.crash-viewer) in ai_tbl !!
06-13 14:01:38.323+0900 E/TASK_MGR_LITE(15431): recent_apps.c: list_retrieve_item(263) > Can't find app (wifi-efl-ug-lite) in ai_tbl !!
06-13 14:01:38.323+0900 E/TASK_MGR_LITE(15431): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.special-day-app) in ai_tbl !!
06-13 14:01:38.323+0900 E/TASK_MGR_LITE(15431): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.wallpaper-ui-service) in ai_tbl !!
06-13 14:01:38.323+0900 E/TASK_MGR_LITE(15431): recent_apps.c: list_retrieve_item(263) > Can't find app (net.wifi-qs) in ai_tbl !!
06-13 14:01:38.323+0900 E/TASK_MGR_LITE(15431): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.smart-switch-noti) in ai_tbl !!
06-13 14:01:38.323+0900 E/TASK_MGR_LITE(15431): recent_apps.c: list_retrieve_item(263) > Can't find app (live-com.samsung.browser) in ai_tbl !!
06-13 14:01:38.323+0900 E/TASK_MGR_LITE(15431): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.weather-m-widget) in ai_tbl !!
06-13 14:01:38.323+0900 E/TASK_MGR_LITE(15431): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.quickpanel) in ai_tbl !!
06-13 14:01:38.323+0900 E/TASK_MGR_LITE(15431): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.setup-wizard) in ai_tbl !!
06-13 14:01:38.323+0900 E/TASK_MGR_LITE(15431): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.pwlock) in ai_tbl !!
06-13 14:01:38.323+0900 E/TASK_MGR_LITE(15431): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.volume) in ai_tbl !!
06-13 14:01:38.323+0900 E/TASK_MGR_LITE(15431): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.lockscreen) in ai_tbl !!
06-13 14:01:38.323+0900 E/TASK_MGR_LITE(15431): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.clock-alarm-service) in ai_tbl !!
06-13 14:01:38.333+0900 I/Tizen::System( 1175): (259) > Active app [com.samsun], current [com.samsun] 
06-13 14:01:38.333+0900 I/Tizen::System( 1175): (273) > Current App[com.samsun] is already actived.
06-13 14:01:38.343+0900 E/EFL     (  342): evas-gl_x11<342> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
06-13 14:01:38.363+0900 E/EFL     (  342): evas-gl_x11<342> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
06-13 14:01:38.383+0900 E/EFL     (  342): evas-gl_x11<342> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
06-13 14:01:38.413+0900 I/APP_CORE(15431): appcore-efl.c: __do_app(514) > [APP 15431] Event: RESET State: CREATED
06-13 14:01:38.413+0900 I/CAPI_APPFW_APPLICATION(15431): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
06-13 14:01:38.413+0900 E/EFL     (15431): edje<15431> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-13 14:01:38.413+0900 E/EFL     (15431): By the power of Grayskull, your previous Embryo stack is now broken!
06-13 14:01:38.413+0900 E/EFL     (15431): edje<15431> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-13 14:01:38.413+0900 E/EFL     (15431): By the power of Grayskull, your previous Embryo stack is now broken!
06-13 14:01:38.423+0900 W/APP_CORE(15431): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:3800003
06-13 14:01:38.423+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 35
06-13 14:01:38.533+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(15431) status(0)
06-13 14:01:38.533+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(15431) status(0)
06-13 14:01:38.533+0900 I/APP_CORE( 1167): appcore-efl.c: __do_app(514) > [APP 1167] Event: PAUSE State: RUNNING
06-13 14:01:38.533+0900 I/CAPI_APPFW_APPLICATION( 1167): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
06-13 14:01:38.533+0900 E/cluster-home( 1167): homescreen.cpp: OnPause(260) >  app pause
06-13 14:01:38.543+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(1167) status(4)
06-13 14:01:38.543+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(1167)
06-13 14:01:38.543+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1167, appid: com.samsung.homescreen, status: bg
06-13 14:01:38.543+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(15431) status(3)
06-13 14:01:38.543+0900 W/AUL_AMD (  607): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-13 14:01:38.543+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
06-13 14:01:38.543+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.task-mgr(15431)
06-13 14:01:38.543+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 15431, appid: com.samsung.task-mgr, status: fg
06-13 14:01:38.543+0900 I/APP_CORE(15431): appcore-efl.c: __do_app(514) > [APP 15431] Event: RESUME State: CREATED
06-13 14:01:38.553+0900 E/EFL     (  342): evas-gl_x11<342> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
06-13 14:01:38.553+0900 E/weather-widget( 1324): Widget4x4Page.cpp: SetRefreshButton(72) > [0;40;31m[SetRefreshButton(): 72] (mCityLayout == NULL) [return][0;m
06-13 14:01:38.553+0900 I/CAPI_WIDGET_APPLICATION( 1324): widget_app.c: __provider_pause_cb(304) > widget obj was paused
06-13 14:01:38.553+0900 I/CAPI_WIDGET_APPLICATION( 1324): widget_app.c: __check_status_for_cgroup(152) > enter background group
06-13 14:01:38.553+0900 W/AUL     ( 1324): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1324, appid: com.samsung.weather-m-widget, status: bg
06-13 14:01:38.563+0900 I/APP_CORE(15431): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
06-13 14:01:38.563+0900 I/APP_CORE(15431): appcore-efl.c: __do_app(625) > [APP 15431] Initial Launching, call the resume_cb
06-13 14:01:38.563+0900 I/CAPI_APPFW_APPLICATION(15431): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-13 14:01:38.603+0900 E/EFL     (  857): ecore_x<857> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=17084814
06-13 14:01:38.603+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=17084814
06-13 14:01:38.603+0900 W/STARTER (  721): hw_key.c: _key_release_cb(578) > [_key_release_cb:578] Home Key is released
06-13 14:01:38.603+0900 E/cluster-view( 1167): homescreen-view-manager.cpp: _OnKeyEvent(1048) >  receive[XF86Home]Key [Up]Event!! 
06-13 14:01:38.603+0900 E/STARTER (  721): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(355) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:355:E] dbus_connection_send error(No reply)
06-13 14:01:38.603+0900 E/STARTER (  721): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(359) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:359:E] dbus_connection_send error(org.freedesktop.DBus.Error.UnknownMethod:Method "getstatus" with signature "" on interface "org.tizen.system.deviced.hall" doesn't exist
06-13 14:01:38.603+0900 E/STARTER (  721): )
06-13 14:01:38.603+0900 I/SYSPOPUP(  859): syspopup.c: __X_syspopup_term_handler(98) > enter syspopup term handler
06-13 14:01:38.603+0900 I/SYSPOPUP(  859): syspopup.c: __X_syspopup_term_handler(108) > term action 1 - volume
06-13 14:01:38.603+0900 E/VOLUME  (  859): volume_x_event.c: volume_x_input_event_unregister(354) > [volume_x_input_event_unregister:354] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
06-13 14:01:38.603+0900 E/VOLUME  (  859): volume_control.c: volume_control_close(841) > [volume_control_close:841] Failed to unregister x input event handler
06-13 14:01:38.913+0900 E/EFL     (15431): ecore_x<15431> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=17085120
06-13 14:01:38.973+0900 E/EFL     (15431): ecore_x<15431> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=17085186
06-13 14:01:39.194+0900 E/RESOURCED(  667): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1591
06-13 14:01:39.194+0900 I/Tizen::App( 1175): (499) > LaunchedApp(com.samsung.task-mgr)
06-13 14:01:39.194+0900 I/Tizen::App( 1175): (733) > Finished invoking application event listener for com.samsung.task-mgr, 15431.
06-13 14:01:39.424+0900 E/EFL     (15431): ecore_x<15431> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=17085631
06-13 14:01:39.514+0900 E/EFL     (15431): ecore_x<15431> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=17085719
06-13 14:01:39.544+0900 E/PKGMGR_SERVER(15793): pkgmgr-server.c: main(2414) > package manager server start
06-13 14:01:39.604+0900 E/PKGMGR  (15791): pkgmgr.c: __check_sync_process(883) > file is can not remove[/tmp/org.example.client, -1]
06-13 14:01:39.654+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 14
06-13 14:01:39.654+0900 W/AUL_AMD (  607): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: -1
06-13 14:01:39.664+0900 E/PKGMGR_SERVER(15793): pkgmgr-server.c: sighandler(417) > child NORMAL exit [15796]
06-13 14:01:40.014+0900 E/EFL     (15431): ecore_x<15431> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=17086225
06-13 14:01:40.084+0900 E/EFL     (15431): ecore_x<15431> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=17086291
06-13 14:01:40.084+0900 I/UXT     (15778): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
06-13 14:01:40.134+0900 E/TBM     (15778): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
06-13 14:01:40.134+0900 I/MALI    (15778): egl_platform_x11.c: __egl_platform_initialize(242) > [EGL-X11] PID=15778   open drm_fd=30 
06-13 14:01:40.265+0900 E/EFL     (15778): edje<15778> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-13 14:01:40.265+0900 E/EFL     (15778): By the power of Grayskull, your previous Embryo stack is now broken!
06-13 14:01:40.265+0900 E/EFL     (15778): edje<15778> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-13 14:01:40.265+0900 E/EFL     (15778): By the power of Grayskull, your previous Embryo stack is now broken!
06-13 14:01:40.265+0900 E/EFL     (15778): edje<15778> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-13 14:01:40.265+0900 E/EFL     (15778): By the power of Grayskull, your previous Embryo stack is now broken!
06-13 14:01:40.395+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 22
06-13 14:01:40.405+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(1201) > app status : 5
06-13 14:01:40.405+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.task-mgr(15431)
06-13 14:01:40.405+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 15431, appid: com.samsung.task-mgr, status: bg
06-13 14:01:40.405+0900 I/CAPI_APPFW_APPLICATION(15431): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
06-13 14:01:40.405+0900 W/TASK_MGR_LITE(15431): task-mgr-lite.c: _pause_app(406) > 
06-13 14:01:40.405+0900 I/CAPI_APPFW_APPLICATION(15431): app_main.c: _ui_app_appcore_terminate(663) > app_appcore_terminate
06-13 14:01:40.415+0900 E/TASK_MGR_LITE(15431): recent_app_viewer.c: destroy_recent_app_viewer(1583) > destroy_recent_app_viewer
06-13 14:01:40.425+0900 E/TASK_MGR_LITE(15431): recent_apps.c: list_destroy(376) > (NULL == list) -> list_destroy() return
06-13 14:01:40.435+0900 E/APP_CORE(15431): appcore.c: appcore_flush_memory(793) > Appcore not initialized
06-13 14:01:40.435+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-13 14:01:40.445+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(1167) status(3)
06-13 14:01:40.445+0900 W/AUL_AMD (  607): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-13 14:01:40.445+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
06-13 14:01:40.445+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(1167)
06-13 14:01:40.445+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1167, appid: com.samsung.homescreen, status: fg
06-13 14:01:40.475+0900 I/MALI    (15431): egl_platform_x11.c: __egl_platform_terminate(358) > [EGL-X11] PID=15431   close drm_fd=30 
06-13 14:01:40.475+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(1167) status(0)
06-13 14:01:40.505+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-13 14:01:40.505+0900 I/APP_CORE( 1167): appcore-efl.c: __do_app(514) > [APP 1167] Event: RESUME State: PAUSED
06-13 14:01:40.505+0900 I/CAPI_APPFW_APPLICATION( 1167): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-13 14:01:40.505+0900 E/cluster-home( 1167): homescreen.cpp: OnResume(233) >  app resume
06-13 14:01:40.555+0900 E/weather-widget( 1324): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
06-13 14:01:40.555+0900 I/Tizen::System( 1175): (259) > Active app [com.samsun], current [com.samsun] 
06-13 14:01:40.555+0900 I/Tizen::System( 1175): (273) > Current App[com.samsun] is already actived.
06-13 14:01:40.565+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetCityPtrWithLocationId(77) > [0;40;31m[GetCityPtrWithLocationId(): 77] (!mCityPtrVector) [return][0;m
06-13 14:01:40.565+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetIndexOfDisplayCity(411) > [0;40;31m[GetIndexOfDisplayCity(): 411] (!cityPtr) [return][0;m
06-13 14:01:40.565+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-13 14:01:40.565+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-13 14:01:40.565+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-13 14:01:40.575+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 15
06-13 14:01:40.585+0900 E/weather-widget( 1324): WidgetMain.cpp: GetCityPtr(125) > [0;40;31m[GetCityPtr(): 125] (!mWeatherInfo) [return][0;m
06-13 14:01:40.585+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-13 14:01:40.585+0900 E/weather-widget( 1324): WidgetMain.cpp: ResumeWidgetInstance(585) > [0;40;31m[ResumeWidgetInstance(): 585] (widgetViewDataPtr->GetNumberOfCities() <= 0) [break][0;m
06-13 14:01:40.585+0900 I/CAPI_WIDGET_APPLICATION( 1324): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
06-13 14:01:40.585+0900 I/CAPI_WIDGET_APPLICATION( 1324): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
06-13 14:01:40.585+0900 W/AUL     ( 1324): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1324, appid: com.samsung.weather-m-widget, status: fg
06-13 14:01:40.665+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[1]
06-13 14:01:40.665+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:01:40.725+0900 I/AUL_PAD ( 1377): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 15431 pgid = 15431
06-13 14:01:40.725+0900 I/AUL_PAD ( 1377): sigchild.h: __sigchild_action(143) > dead_pid(15431)
06-13 14:01:40.765+0900 I/AUL_PAD ( 1377): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
06-13 14:01:40.765+0900 I/AUL_PAD ( 1377): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
06-13 14:01:40.765+0900 E/AUL_PAD ( 1377): launchpad.c: main(698) > error reading sigchld info
06-13 14:01:40.765+0900 I/ESD     (  898): esd_main.c: __esd_app_dead_handler(1773) > pid: 15431
06-13 14:01:40.765+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 15431
06-13 14:01:40.765+0900 I/Tizen::App( 1175): (243) > App[com.samsung.task-mgr] pid[15431] terminate event is forwarded
06-13 14:01:40.765+0900 I/Tizen::System( 1175): (256) > osp.accessorymanager.service provider is found.
06-13 14:01:40.765+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 15431
06-13 14:01:40.765+0900 I/Tizen::System( 1175): (196) > Accessory Owner is removed [com.samsung.task-mgr, 15431, ]
06-13 14:01:40.765+0900 I/Tizen::System( 1175): (256) > osp.system.service provider is found.
06-13 14:01:40.765+0900 I/Tizen::App( 1175): (506) > TerminatedApp(com.samsung.task-mgr)
06-13 14:01:40.765+0900 I/Tizen::App( 1175): (512) > Not registered pid(15431)
06-13 14:01:40.765+0900 I/Tizen::System( 1175): (246) > Terminated app [com.samsung.task-mgr]
06-13 14:01:40.765+0900 I/Tizen::Io( 1175): (729) > Entry not found
06-13 14:01:40.775+0900 E/RESOURCED(  667): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1596
06-13 14:01:40.785+0900 I/Tizen::System( 1175): (157) > change brightness system value.
06-13 14:01:40.785+0900 I/Tizen::App( 1175): (782) > Finished invoking application event listener for com.samsung.task-mgr, 15431.
06-13 14:01:41.406+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=17087556
06-13 14:01:41.406+0900 E/cluster-view( 1167): homescreen-view-manager.cpp: _OnKeyEvent(1048) >  receive[XF86Back]Key [Down]Event!! 
06-13 14:01:41.416+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=17087617
06-13 14:01:41.416+0900 E/cluster-view( 1167): homescreen-view-manager.cpp: _OnKeyEvent(1048) >  receive[XF86Back]Key [Up]Event!! 
06-13 14:01:41.796+0900 E/PKGMGR_SERVER(15793): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
06-13 14:01:41.796+0900 E/PKGMGR_SERVER(15793): pkgmgr-server.c: main(2471) > package manager server terminated.
06-13 14:01:42.116+0900 W/AUL_AMD (  607): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
06-13 14:01:44.419+0900 E/PKGMGR  (15888): pkgmgr.c: pkgmgr_client_reinstall(2020) > reinstall pkg start.
06-13 14:01:44.499+0900 E/PKGMGR_SERVER(15890): pkgmgr-server.c: main(2414) > package manager server start
06-13 14:01:44.559+0900 E/PKGMGR_SERVER(15890): pkgmgr-server-internal.c: _zone_set_type_and_backend(180) > tep_filepath [org.example.client]
06-13 14:01:44.569+0900 E/PKGMGR_SERVER(15890): pm-mdm.c: _get_package_info_from_file(116) > [0;31m[_get_package_info_from_file(): 116](ret < 0) access() failed. path: org.example.client errno: 2 (No such file or directory)[0;m
06-13 14:01:44.569+0900 E/PKGMGR  (15888): pkgmgr.c: pkgmgr_client_reinstall(2133) > reinstall pkg finish, ret=[158880002]
06-13 14:01:44.729+0900 I/Tizen::App( 1175): (1894) > PackageEventHandler - req: 11750002, pkg_type: tpk, pkg_name: org.example.client, key: start, val: update
06-13 14:01:44.729+0900 I/Tizen::App( 1175): (1584) > Package = [org.example.client], Key = [start], Value = [update], install = [1]
06-13 14:01:44.729+0900 E/PKGMGR  ( 4377): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-13 14:01:44.729+0900 E/PKGMGR  ( 4377): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-13 14:01:44.729+0900 W/AUL_AMD (  607): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(1068) > __amd_pkgmgrinfo_start_handler
06-13 14:01:44.739+0900 I/Tizen::App( 1175): (1894) > PackageEventHandler - req: 11750002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 30
06-13 14:01:44.739+0900 I/Tizen::App( 1175): (119) > InstallationInProgress [30]
06-13 14:01:44.739+0900 I/Tizen::App( 1175): (1584) > Package = [org.example.client], Key = [install_percent], Value = [30], install = [1]
06-13 14:01:44.739+0900 E/PKGMGR  ( 4377): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-13 14:01:44.739+0900 E/PKGMGR  ( 4377): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-13 14:01:45.019+0900 E/rpm-installer(15893): coretpk-parser.c: _coretpk_parser_get_manifest_info(1183) > (doc == NULL) xmlParseFile() failed.
06-13 14:01:45.019+0900 E/rpm-installer(15893): coretpk-installer.c: _coretpk_installer_verify_privilege_list(1594) > (pkg_file_info == NULL) pkg_file_info is NULL.
06-13 14:01:45.069+0900 E/PKGMGR_PARSER(15893): pkgmgr_parser.c: __check_theme(154) > theme for uninstallation.
06-13 14:01:45.089+0900 I/PRIVACY-MANAGER-CLIENT(15893): SocketClient.cpp: SocketClient(37) > Client created
06-13 14:01:45.089+0900 I/PRIVACY-MANAGER-CLIENT(15893): SocketClient.cpp: connect(62) > Client connected
06-13 14:01:45.089+0900 I/PRIVACY-MANAGER-SERVER(  914): SocketService.cpp: mainloop(230) > Got incoming connection
06-13 14:01:45.089+0900 I/PRIVACY-MANAGER-CLIENT(15893): SocketClient.cpp: disconnect(72) > Client disconnected
06-13 14:01:45.099+0900 E/PKGMGR_CERT(15893): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(617) > Transaction Begin
06-13 14:01:45.099+0900 E/PKGMGR_CERT(15893): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(622) > Certificate Deletion Success
06-13 14:01:45.109+0900 E/PKGMGR_CERT(15893): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(635) > Transaction Commit and End
06-13 14:01:45.139+0900 E/rpm-installer(15893): coretpk-installer.c: _coretpk_installer_package_reinstall(6347) > _coretpk_installer_package_reinstall(org.example.client) failed.
06-13 14:01:45.149+0900 E/PKGMGR  ( 4377): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-13 14:01:45.149+0900 I/Tizen::App( 1175): (1894) > PackageEventHandler - req: 11750002, pkg_type: tpk, pkg_name: org.example.client, key: end, val: fail
06-13 14:01:45.149+0900 E/PKGMGR  ( 4377): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-13 14:01:45.149+0900 I/Tizen::App( 1175): (1584) > Package = [org.example.client], Key = [end], Value = [fail], install = [1]
06-13 14:01:45.149+0900 E/ESD     (  898): esd_main.c: __esd_pkgmgr_event_callback(1757) > pkg_event(3) falied
06-13 14:01:45.149+0900 W/AUL_AMD (  607): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(1111) > __amd_pkgmgrinfo_fail_handler
06-13 14:01:45.159+0900 W/ISF_PANEL_EFL(  765): isf_panel_efl.cpp: _isf_insert_ime_info_by_pkgid(1168) > pkgmgrinfo_pkginfo_get_pkginfo("org.example.client",~) returned -1
06-13 14:01:45.159+0900 W/ISF_PANEL_EFL(  765): isf_panel_efl.cpp: _package_manager_event_cb(1381) > isf_db_select_appids_by_pkgid returned 0.
06-13 14:01:45.400+0900 W/AUL_AMD (  607): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
06-13 14:01:46.791+0900 E/PKGMGR_SERVER(15890): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=0, queue_status=1, drm_status=1] 
06-13 14:01:46.821+0900 E/PKGMGR_SERVER(15890): pkgmgr-server.c: sighandler(417) > child NORMAL exit [15893]
06-13 14:01:48.793+0900 E/PKGMGR_SERVER(15890): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
06-13 14:01:48.793+0900 E/PKGMGR_SERVER(15890): pkgmgr-server.c: main(2471) > package manager server terminated.
06-13 14:01:49.163+0900 E/PKGMGR  (15942): pkgmgr.c: pkgmgr_client_install(1605) > install pkg start.
06-13 14:01:49.233+0900 E/PKGMGR_SERVER(15944): pkgmgr-server.c: main(2414) > package manager server start
06-13 14:01:49.293+0900 E/PKGMGR_SERVER(15944): pkgmgr-server-internal.c: _zone_set_type_and_backend(180) > tep_filepath [/opt/usr/apps/tmp/org.example.client-1.0.0-arm.tpk]
06-13 14:01:49.303+0900 E/PKGMGR_INFO(15944): pkgmgrinfo_pkginfo.c: pkgmgrinfo_pkginfo_get_unmounted_pkginfo(778) > (exist == 0) pkgid[/opt/usr/apps/tmp/org.example.client-1.0.0-arm.tpk] not found in DB
06-13 14:01:49.313+0900 E/rpm-installer(15944): librpm.c: __installer_util_delete_dir(171) > opendir(/tmp/coretpk-unzip) failed. [2][No such file or directory]
06-13 14:01:49.323+0900 E/PKGMGR_SERVER(15944): pm-mdm.c: _pm_check_mdm_policy(75) > [0;31m[_pm_check_mdm_policy(): 75](ret != MDM_RESULT_SUCCESS) can not connect mdm server[0;m
06-13 14:01:49.323+0900 E/PKGMGR  (15942): pkgmgr.c: pkgmgr_client_install(1723) > install pkg finish, ret=[159420002]
06-13 14:01:49.444+0900 E/PKGMGR_INSTALLER(15947): pkgmgr_installer.c: pkgmgr_installer_receive_request(225) > option is [i]
06-13 14:01:49.444+0900 E/rpm-installer(15947): rpm-appcore-intf.c: main(186) > [/opt/usr/apps/tmp/org.example.client-1.0.0-arm.tpk] is tpk package.
06-13 14:01:49.464+0900 E/rpm-installer(15947): coretpk-parser.c: _coretpk_parser_is_svc_app(1031) > (ret == 1) NodeSet is empty. (//*[name() = 'manifest']/*[name()='service-application'])
06-13 14:01:49.464+0900 E/rpm-installer(15947): coretpk-parser.c: __coretpk_parser_get_value(1147) > (result_value == NULL) [install-location] is empty.
06-13 14:01:49.464+0900 E/rpm-installer(15947): coretpk-parser.c: __coretpk_parser_is_theme(31) > (ret == 1) metadata(watchface) is empty.
06-13 14:01:49.464+0900 E/rpm-installer(15947): coretpk-parser.c: _coretpk_parser_is_widget(997) > (ret == 1) NodeSet is empty. (//*[name() = 'manifest']/*[name()='widget-application'])
06-13 14:01:49.464+0900 E/rpm-installer(15947): installer-util.c: _installer_util_get_configuration_value(565) > [signature]=[on]
06-13 14:01:49.564+0900 I/Tizen::App( 1175): (1894) > PackageEventHandler - req: 11750002, pkg_type: tpk, pkg_name: org.example.client, key: start, val: install
06-13 14:01:49.564+0900 I/Tizen::App( 1175): (1584) > Package = [org.example.client], Key = [start], Value = [install], install = [1]
06-13 14:01:49.564+0900 E/PKGMGR  ( 4377): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-13 14:01:49.564+0900 E/PKGMGR  ( 4377): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-13 14:01:49.574+0900 I/Tizen::App( 1175): (1894) > PackageEventHandler - req: 11750002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 30
06-13 14:01:49.574+0900 I/Tizen::App( 1175): (119) > InstallationInProgress [30]
06-13 14:01:49.574+0900 I/Tizen::App( 1175): (1584) > Package = [org.example.client], Key = [install_percent], Value = [30], install = [1]
06-13 14:01:49.574+0900 E/PKGMGR  ( 4377): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-13 14:01:49.574+0900 E/PKGMGR  ( 4377): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-13 14:01:49.854+0900 E/rpm-installer(15947): coretpk-parser.c: __coretpk_parser_check_vip_tag(396) > (ret == 1) metadata(watchface) is empty.
06-13 14:01:49.854+0900 E/rpm-installer(15947): coretpk-parser.c: __coretpk_parser_get_value(1147) > (result_value == NULL) [ui-gadget] is empty.
06-13 14:01:49.864+0900 E/rpm-installer(15947): coretpk-parser.c: __coretpk_parser_append_path(335) > (ret == 1) NodeSet is empty. (//@portrait-effectimage)
06-13 14:01:49.864+0900 E/rpm-installer(15947): coretpk-parser.c: __coretpk_parser_is_theme(31) > (ret == 1) metadata(watchface) is empty.
06-13 14:01:49.864+0900 E/rpm-installer(15947): coretpk-parser.c: __coretpk_parser_allow_onboot(504) > (ret == 1) metadata is empty.
06-13 14:01:49.864+0900 E/rpm-installer(15947): coretpk-parser.c: __coretpk_parser_allow_autorestart(566) > (ret == 1) metadata is empty.
06-13 14:01:49.864+0900 E/PKGMGR_PARSER(15947): pkgmgr_parser.c: pkgmgr_parser_check_manifest_validation(2678) > Manifest is Valid
06-13 14:01:49.874+0900 E/PKGMGR_PARSER(15947): pkgmgr_parser_signature.c: __ps_check_mdm_policy(979) > (ret != MDM_RESULT_SUCCESS) can not connect mdm server
06-13 14:01:49.914+0900 I/PRIVACY-MANAGER-CLIENT(15947): SocketClient.cpp: SocketClient(37) > Client created
06-13 14:01:50.124+0900 E/PKGMGR_PARSER(15947): pkgmgr_parser.c: __check_theme(142) > theme for installation.
06-13 14:01:50.144+0900 E/PKGMGR_CERT(15947): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(427) > Transaction Begin
06-13 14:01:50.144+0900 E/PKGMGR_CERT(15947): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 1 107
06-13 14:01:50.144+0900 E/PKGMGR_CERT(15947): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 2 107
06-13 14:01:50.144+0900 E/PKGMGR_CERT(15947): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 44 1
06-13 14:01:50.144+0900 E/PKGMGR_CERT(15947): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 38 2
06-13 14:01:50.144+0900 E/PKGMGR_CERT(15947): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 39 2
06-13 14:01:50.144+0900 E/PKGMGR_CERT(15947): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 45 1
06-13 14:01:50.154+0900 E/PKGMGR_CERT(15947): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(576) > Transaction Commit and End
06-13 14:01:50.154+0900 E/rpm-installer(15947): coretpk-installer.c: _coretpk_installer_apply_directory_policy(1956) > skip! empty dirpath=[/opt/usr/apps/org.example.client/lib]
06-13 14:01:50.154+0900 E/PKGMGR  ( 4377): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-13 14:01:50.154+0900 I/Tizen::App( 1175): (1894) > PackageEventHandler - req: 11750002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 60
06-13 14:01:50.154+0900 E/PKGMGR  ( 4377): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-13 14:01:50.154+0900 I/Tizen::App( 1175): (119) > InstallationInProgress [60]
06-13 14:01:50.154+0900 I/Tizen::App( 1175): (1584) > Package = [org.example.client], Key = [install_percent], Value = [60], install = [1]
06-13 14:01:50.174+0900 E/rpm-installer(15947): installer-util.c: _installer_util_get_configuration_value(565) > [signature]=[on]
06-13 14:01:50.194+0900 E/rpm-installer(15947): coretpk-installer.c: __post_install_for_mmc(652) > (handle == NULL) handle is NULL.
06-13 14:01:50.194+0900 E/PKGMGR  ( 4377): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-13 14:01:50.194+0900 I/Tizen::App( 1175): (1894) > PackageEventHandler - req: 11750002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 100
06-13 14:01:50.194+0900 E/PKGMGR  ( 4377): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-13 14:01:50.194+0900 I/Tizen::App( 1175): (119) > InstallationInProgress [100]
06-13 14:01:50.194+0900 I/Tizen::App( 1175): (1584) > Package = [org.example.client], Key = [install_percent], Value = [100], install = [1]
06-13 14:01:51.796+0900 E/PKGMGR_SERVER(15944): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=0, queue_status=1, drm_status=1] 
06-13 14:01:52.066+0900 I/Tizen::App( 1175): (1894) > PackageEventHandler - req: 11750002, pkg_type: tpk, pkg_name: org.example.client, key: end, val: ok
06-13 14:01:52.066+0900 I/Tizen::App( 1175): (78) > Installation is Completed. [Package = org.example.client]
06-13 14:01:52.066+0900 I/Tizen::App( 1175): (671) > Enter. package(org.example.client), installationResult(0)
06-13 14:01:52.076+0900 E/cluster-home( 1167): mainmenu-package-manager.cpp: OnClientListenCb(571) >  #Step 1
06-13 14:01:52.076+0900 E/cluster-home( 1167): mainmenu-package-manager.cpp: OnClientListenCb(575) >  #Step 2
06-13 14:01:52.076+0900 E/cluster-home( 1167): mainmenu-package-manager.cpp: _GetAppIds(350) >  BEGIN
06-13 14:01:52.086+0900 I/Tizen::App( 1175): (1360) > package(org.example.client), version(1.0.0), type(tpk), displayName(client), uninstallable(1), downloaded(1), updated(0), preloaded(0)movable(1), externalStorage(0), mainApp(org.example.client), storeClient(), appRootPath(/opt/usr/apps/org.example.client)
06-13 14:01:52.106+0900 W/ISF_PANEL_EFL(  765): isf_panel_efl.cpp: _package_manager_event_cb(1513) > _isf_insert_ime_info_by_pkgid returned 0.
06-13 14:01:52.106+0900 E/PKGMGR  ( 4377): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-13 14:01:52.106+0900 E/PKGMGR  ( 4377): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-13 14:01:52.116+0900 I/Tizen::App( 1175): (483) > pkgmgrinfo_appinfo_get_appid(): app = [org.example.client]
06-13 14:01:52.116+0900 E/PKGMGR_SERVER(15944): pkgmgr-server.c: sighandler(417) > child NORMAL exit [15947]
06-13 14:01:52.116+0900 E/cluster-home( 1167): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(253) >  ##### [org.example.client]
06-13 14:01:52.126+0900 E/cluster-home( 1167): mainmenu-package-manager.cpp: _GetAppIds(375) >  ##### [org.example.client]
06-13 14:01:52.126+0900 E/cluster-home( 1167): mainmenu-package-manager.cpp: _GetAppIds(379) >  END
06-13 14:01:52.126+0900 E/cluster-home( 1167): mainmenu-package-manager.cpp: _DoPkgJob(458) >  #Step 3 size[1]
06-13 14:01:52.126+0900 E/cluster-home( 1167): mainmenu-package-manager.cpp: _DoPkgJob(462) >  appId[org.example.client]
06-13 14:01:52.126+0900 E/RESOURCED(  667): procfs.c: proc_get_oom_score_adj(131) > fopen /proc/15947/oom_score_adj failed
06-13 14:01:52.126+0900 E/RESOURCED(  667): proc-main.c: resourced_proc_status_change(867) > Empty pid or process not exists. 15947
06-13 14:01:52.126+0900 I/Tizen::App( 1175): (416) > appName = [client]
06-13 14:01:52.126+0900 I/Tizen::App( 1175): (509) > exe = [/opt/usr/apps/org.example.client/bin/client], displayName = [client], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
06-13 14:01:52.126+0900 E/PKGMGR_INFO( 1175): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(887) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
06-13 14:01:52.126+0900 I/Tizen::App( 1175): (683) > Application count(1) in this package
06-13 14:01:52.126+0900 I/Tizen::App( 1175): (840) > Enter.
06-13 14:01:52.136+0900 I/Tizen::App( 1175): (703) > Exit.
06-13 14:01:52.136+0900 I/Tizen::App( 1175): (1584) > Package = [org.example.client], Key = [end], Value = [ok], install = [1]
06-13 14:01:52.136+0900 E/cluster-home( 1167): mainmenu-package-manager.cpp: _GetAppInfo(990) >  Name[client] enable[1] system[0]
06-13 14:01:52.136+0900 E/HOME_APPS( 1167): mainmenu-package-manager.cpp: _DoPkgJob(484) >  appId[org.example.client] mdm is not enabled
06-13 14:01:52.136+0900 E/cluster-home( 1167): mainmenu-package-manager.cpp: GetAppInfo(630) >  Find a App Info Name[client] enable[1] system[0]
06-13 14:01:52.136+0900 W/HOME_APPS( 1167): mainmenu-box-impl.cpp: UpdateBoxData(1326) >  update box data!!!!! old icon path[/opt/usr/apps/org.example.client/shared/res/client.png], New icon path[/opt/usr/apps/org.example.client/shared/res/client.png]!!!!!
06-13 14:01:52.146+0900 I/Tizen::App( 1175): (416) > appName = [client]
06-13 14:01:52.146+0900 I/Tizen::App( 1175): (509) > exe = [/opt/usr/apps/org.example.client/bin/client], displayName = [client], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
06-13 14:01:52.146+0900 I/Tizen::App( 1175): (2343) > info file is not existed. [/opt/usr/apps/org.exampl/info/org.example.client.info]
06-13 14:01:52.146+0900 I/Tizen::App( 1175): (131) > Enter
06-13 14:01:52.146+0900 I/Tizen::App( 1175): (137) > org.example.client does not have launch condition
06-13 14:01:52.146+0900 I/Tizen::App( 1175): (883) > Exit.
06-13 14:01:52.156+0900 E/util-view( 1167): util-text-image-provider.cpp: GetPixelsFromText(240) >  DEFAULT='font=SamsungOneUI:style=Regular style=shadow,bottom shadow_color=# font_size=28 align=center valign=top color=#FFFFFF color_class=ATO001 text_class=ATO001 ellipsis=1 wrap=mixed linegap=-3'
06-13 14:01:52.196+0900 W/HOME_APPS( 1167): mainmenu-box-impl.cpp: _OnImageLoadFinishedHandler(2152) >  finished path[/opt/usr/apps/org.example.client/shared/res/client.png], Loading state:[1]
06-13 14:01:53.788+0900 E/PKGMGR_SERVER(15944): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
06-13 14:01:53.788+0900 E/PKGMGR_SERVER(15944): pkgmgr-server.c: main(2471) > package manager server terminated.
06-13 14:01:56.360+0900 W/AUL     (16003): launch.c: app_request_to_launchpad(396) > request cmd(0) to(org.example.client)
06-13 14:01:56.360+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 0
06-13 14:01:56.370+0900 I/AUL     (  607): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/launch_app, ret : 0
06-13 14:01:56.370+0900 I/AUL     (  607): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /bin/bash, ret : 0
06-13 14:01:56.370+0900 E/AUL_AMD (  607): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
06-13 14:01:56.370+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(2508) > caller pid : 16003
06-13 14:01:56.370+0900 E/AUL_AMD (  607): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
06-13 14:01:56.380+0900 E/RESOURCED(  667): block.c: block_prelaunch_state(134) > insert data org.example.client, table num : 6
06-13 14:01:56.380+0900 E/RESOURCED(  667): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-13 14:01:56.390+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(3052) > pad pid(-5)
06-13 14:01:56.390+0900 W/AUL_PAD ( 1377): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
06-13 14:01:56.390+0900 W/AUL_PAD ( 1377): launchpad.c: __send_result_to_caller(267) > Check app launching
06-13 14:01:56.400+0900 I/abc     (15731): abc
06-13 14:01:56.400+0900 I/CAPI_APPFW_APPLICATION(15731): app_main.c: ui_app_main(789) > app_efl_main
06-13 14:01:56.400+0900 I/CAPI_APPFW_APPLICATION(15731): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
06-13 14:01:56.430+0900 E/TBM     (15731): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
06-13 14:01:56.490+0900 W/AUL     (  607): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 15731, appid: org.example.client
06-13 14:01:56.490+0900 E/AUL     (  607): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
06-13 14:01:56.490+0900 W/AUL     (16003): launch.c: app_request_to_launchpad(425) > request cmd(0) result(15731)
06-13 14:01:56.931+0900 W/CRASH_MANAGER(16018): worker.c: worker_job(1199) > 0415731636c69149733011
