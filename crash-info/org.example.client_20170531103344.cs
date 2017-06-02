S/W Version Information
Model: SM-Z300H
Tizen-Version: 2.4.0.3
Build-Number: Z300HDDU0BPI2
Build-Date: 2016.09.30 15:37:12

Crash Information
Process Name: client
PID: 21207
Date: 2017-05-31 10:33:44+0900
Executable File Path: /opt/usr/apps/org.example.client/bin/client
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 21207, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0x800bafda
r2   = 0x00000000, r3   = 0x00000000
r4   = 0xb279d345, r5   = 0xb7fde380
r6   = 0xb80e0c58, r7   = 0xbef571a0
r8   = 0x800bafda, r9   = 0xb5ea0708
r10  = 0xb80d02a0, fp   = 0x00000000
ip   = 0x800bafda, sp   = 0xbef57188
lr   = 0x00000000, pc   = 0xb279d358
cpsr = 0x600f0030

Memory Information
MemTotal:   987012 KB
MemFree:     80560 KB
Buffers:     73272 KB
Cached:     269860 KB
VmPeak:     135572 KB
VmSize:     134412 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       29724 KB
VmRSS:       28916 KB
VmData:      46288 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       35840 KB
VmPTE:         102 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 21207 TID = 21207
21207 21208 21264 21265 21289 

Maps Information
aee4c000 af64b000 rw-p [stack:21289]
b0d84000 b0d95000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b0da5000 b0daa000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b1336000 b133e000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b1350000 b1b4f000 rw-p [stack:21265]
b1b4f000 b1b50000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b1b60000 b1b74000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b1b88000 b1b89000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b1b99000 b1b9c000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b1bad000 b1bae000 r-xp /usr/lib/libxshmfence.so.1.0.0
b1bbe000 b1bc0000 r-xp /usr/lib/libxcb-present.so.0.0.0
b1bd0000 b1bd2000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b1be2000 b1bf2000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b1c02000 b1c0e000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b1c20000 b241f000 rw-p [stack:21264]
b2750000 b2757000 r-xp /usr/lib/libefl-extension.so.0.1.0
b276a000 b2770000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b2780000 b27ab000 r-xp /opt/usr/apps/org.example.client/bin/client
b2904000 b29e7000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2a1e000 b2a46000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2a58000 b3257000 rw-p [stack:21208]
b3257000 b3259000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b3269000 b3273000 r-xp /lib/libnss_files-2.20-2014.11.so
b3284000 b328d000 r-xp /lib/libnss_nis-2.20-2014.11.so
b329e000 b32af000 r-xp /lib/libnsl-2.20-2014.11.so
b32c2000 b32c8000 r-xp /lib/libnss_compat-2.20-2014.11.so
b32d9000 b32da000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b3302000 b3309000 r-xp /usr/lib/libminizip.so.1.0.0
b3319000 b331e000 r-xp /usr/lib/libstorage.so.0.1
b332e000 b338d000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b33a3000 b33b7000 r-xp /usr/lib/libcapi-media-camera.so.0.1.90
b33c7000 b340b000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b341b000 b3423000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b3433000 b3463000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b3476000 b352f000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b3543000 b3596000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b35a7000 b35c2000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b35d2000 b3693000 r-xp /usr/lib/libprotobuf.so.9.0.1
b36a6000 b36b6000 r-xp /usr/lib/libefl-assist.so.0.1.0
b36c6000 b36d3000 r-xp /usr/lib/libmdm-common.so.1.0.98
b36e4000 b36eb000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b36fb000 b373c000 r-xp /usr/lib/libmdm.so.1.2.12
b374c000 b3754000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b3763000 b3773000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b3794000 b37f4000 r-xp /usr/lib/libasound.so.2.0.0
b3806000 b3809000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b3819000 b381c000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b382c000 b3831000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b3841000 b3842000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b3852000 b385d000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b3871000 b3878000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b3888000 b388e000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b389e000 b38a3000 r-xp /usr/lib/libmmfsession.so.0.0.1
b38b3000 b38ce000 r-xp /usr/lib/libmmfsound.so.0.1.0
b38de000 b38e5000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b38f5000 b38f8000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b3909000 b3937000 r-xp /usr/lib/libidn.so.11.5.44
b3947000 b395d000 r-xp /usr/lib/libnghttp2.so.5.4.0
b396e000 b3978000 r-xp /usr/lib/libcares.so.2.1.0
b3988000 b3992000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.32
b39a2000 b39a4000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.18
b39b4000 b39b5000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b39c5000 b39c9000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b39da000 b3a02000 r-xp /usr/lib/libui-extension.so.0.1.0
b3a13000 b3a3c000 r-xp /usr/lib/libturbojpeg.so
b3a5c000 b3a62000 r-xp /usr/lib/libgif.so.4.1.6
b3a72000 b3ab8000 r-xp /usr/lib/libcurl.so.4.3.0
b3ac9000 b3aea000 r-xp /usr/lib/libexif.so.12.3.3
b3b05000 b3b1a000 r-xp /usr/lib/libtts.so
b3b2b000 b3b33000 r-xp /usr/lib/libfeedback.so.0.1.4
b3b43000 b3c09000 r-xp /usr/lib/libdali-core.so.0.0.0
b3c29000 b3d21000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b3d40000 b3e0e000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b3e25000 b3e27000 r-xp /usr/lib/libboost_system.so.1.51.0
b3e37000 b3e3d000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b3e4d000 b3e70000 r-xp /usr/lib/libboost_thread.so.1.51.0
b3e81000 b3e83000 r-xp /usr/lib/libappsvc.so.0.1.0
b3e93000 b3e95000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b3ea6000 b3eab000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b3ec2000 b3ec4000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b3ed4000 b3edb000 r-xp /usr/lib/libsensord-share.so
b3eeb000 b3f03000 r-xp /usr/lib/libsensor.so.1.1.0
b3f14000 b3f17000 r-xp /usr/lib/libXv.so.1.0.0
b3f27000 b3f2c000 r-xp /usr/lib/libutilX.so.1.1.0
b3f3c000 b3f41000 r-xp /usr/lib/libappcore-common.so.1.1
b3f51000 b3f58000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.11
b3f6b000 b3f6f000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b3f80000 b405e000 r-xp /usr/lib/libCOREGL.so.4.0
b407e000 b4081000 r-xp /usr/lib/libuuid.so.1.3.0
b4091000 b40a8000 r-xp /usr/lib/libblkid.so.1.1.0
b40b9000 b40bb000 r-xp /usr/lib/libXau.so.6.0.0
b40cb000 b4112000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b4124000 b412a000 r-xp /usr/lib/libjson-c.so.2.0.1
b413b000 b413f000 r-xp /usr/lib/libogg.so.0.7.1
b414f000 b4171000 r-xp /usr/lib/libvorbis.so.0.4.3
b4181000 b4265000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b4281000 b4284000 r-xp /usr/lib/libEGL.so.1.4
b4295000 b429b000 r-xp /usr/lib/libxcb-render.so.0.0.0
b42ab000 b42ad000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b42bd000 b42ca000 r-xp /usr/lib/libGLESv2.so.2.0
b42db000 b433d000 r-xp /usr/lib/libpixman-1.so.0.28.2
b4352000 b436a000 r-xp /usr/lib/libmount.so.1.1.0
b437c000 b4390000 r-xp /usr/lib/libxcb.so.1.1.0
b43a0000 b43a7000 r-xp /lib/libcrypt-2.20-2014.11.so
b43df000 b43e1000 r-xp /usr/lib/libiri.so
b43f1000 b43fc000 r-xp /usr/lib/libgpg-error.so.0.15.0
b440d000 b4443000 r-xp /usr/lib/libpulse.so.0.16.2
b4454000 b4497000 r-xp /usr/lib/libsndfile.so.1.0.25
b44ac000 b44c1000 r-xp /lib/libexpat.so.1.5.2
b44d3000 b4591000 r-xp /usr/lib/libcairo.so.2.11200.14
b45a5000 b45ad000 r-xp /usr/lib/libdrm.so.2.4.0
b45bd000 b45c0000 r-xp /usr/lib/libdri2.so.0.0.0
b45d0000 b461e000 r-xp /usr/lib/libssl.so.1.0.0
b4633000 b463f000 r-xp /usr/lib/libeeze.so.1.13.0
b4650000 b4659000 r-xp /usr/lib/libethumb.so.1.13.0
b4669000 b466c000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b467c000 b4833000 r-xp /usr/lib/libcrypto.so.1.0.0
b561e000 b5627000 r-xp /usr/lib/libXi.so.6.1.0
b5637000 b5639000 r-xp /usr/lib/libXgesture.so.7.0.0
b5649000 b564d000 r-xp /usr/lib/libXtst.so.6.1.0
b565d000 b5663000 r-xp /usr/lib/libXrender.so.1.3.0
b5673000 b5679000 r-xp /usr/lib/libXrandr.so.2.2.0
b5689000 b568b000 r-xp /usr/lib/libXinerama.so.1.0.0
b569c000 b569f000 r-xp /usr/lib/libXfixes.so.3.1.0
b56af000 b56ba000 r-xp /usr/lib/libXext.so.6.4.0
b56ca000 b56cc000 r-xp /usr/lib/libXdamage.so.1.1.0
b56dc000 b56de000 r-xp /usr/lib/libXcomposite.so.1.0.0
b56ee000 b57d0000 r-xp /usr/lib/libX11.so.6.3.0
b57e4000 b57eb000 r-xp /usr/lib/libXcursor.so.1.0.2
b57fb000 b5813000 r-xp /usr/lib/libudev.so.1.6.0
b5815000 b5818000 r-xp /lib/libattr.so.1.1.0
b5828000 b5848000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5849000 b584e000 r-xp /usr/lib/libffi.so.6.0.2
b585f000 b5877000 r-xp /lib/libz.so.1.2.8
b5887000 b5889000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b5899000 b596e000 r-xp /usr/lib/libxml2.so.2.9.2
b5983000 b5a1e000 r-xp /usr/lib/libstdc++.so.6.0.20
b5a3a000 b5a3d000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5a4d000 b5a66000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5a77000 b5a88000 r-xp /lib/libresolv-2.20-2014.11.so
b5a9c000 b5b16000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5b2b000 b5b2d000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5b3d000 b5b44000 r-xp /usr/lib/libembryo.so.1.13.0
b5b54000 b5b5e000 r-xp /usr/lib/libecore_audio.so.1.13.0
b5b6f000 b5b87000 r-xp /usr/lib/libpng12.so.0.50.0
b5b98000 b5bbb000 r-xp /usr/lib/libjpeg.so.8.0.2
b5bdc000 b5bf0000 r-xp /usr/lib/libector.so.1.13.0
b5c01000 b5c19000 r-xp /usr/lib/liblua-5.1.so
b5c2a000 b5c81000 r-xp /usr/lib/libfreetype.so.6.11.3
b5c95000 b5cbd000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5cce000 b5ce1000 r-xp /usr/lib/libfribidi.so.0.3.1
b5cf2000 b5d2c000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5d3d000 b5d4b000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5d5b000 b5d63000 r-xp /usr/lib/libtbm.so.1.0.0
b5d73000 b5d80000 r-xp /usr/lib/libeio.so.1.13.0
b5d90000 b5d92000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5da2000 b5da7000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5db7000 b5dce000 r-xp /usr/lib/libefreet.so.1.13.0
b5de0000 b5e00000 r-xp /usr/lib/libeldbus.so.1.13.0
b5e10000 b5e30000 r-xp /usr/lib/libecore_con.so.1.13.0
b5e32000 b5e38000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5e48000 b5e59000 r-xp /usr/lib/libemotion.so.1.13.0
b5e6a000 b5e71000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5e81000 b5e90000 r-xp /usr/lib/libeo.so.1.13.0
b5ea1000 b5eb3000 r-xp /usr/lib/libecore_input.so.1.13.0
b5ec4000 b5ec9000 r-xp /usr/lib/libecore_file.so.1.13.0
b5ed9000 b5ef2000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5f02000 b5f1f000 r-xp /usr/lib/libeet.so.1.13.0
b5f38000 b5f80000 r-xp /usr/lib/libeina.so.1.13.0
b5f91000 b5fa1000 r-xp /usr/lib/libefl.so.1.13.0
b5fb2000 b6097000 r-xp /usr/lib/libicuuc.so.51.1
b60b4000 b61f4000 r-xp /usr/lib/libicui18n.so.51.1
b620b000 b6243000 r-xp /usr/lib/libecore_x.so.1.13.0
b6255000 b6258000 r-xp /lib/libcap.so.2.21
b6268000 b6291000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b62a2000 b62a9000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b62bb000 b62f2000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b6303000 b63ee000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b6401000 b647a000 r-xp /usr/lib/libsqlite3.so.0.8.6
b648c000 b6491000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b64a1000 b64ab000 r-xp /usr/lib/libvconf.so.0.2.45
b64bb000 b64bd000 r-xp /usr/lib/libvasum.so.0.3.1
b64cd000 b64cf000 r-xp /usr/lib/libttrace.so.1.1
b64df000 b64e2000 r-xp /usr/lib/libiniparser.so.0
b64f2000 b6518000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6528000 b652d000 r-xp /usr/lib/libxdgmime.so.1.1.0
b653e000 b6555000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6566000 b65d1000 r-xp /lib/libm-2.20-2014.11.so
b65e2000 b65e8000 r-xp /lib/librt-2.20-2014.11.so
b65f9000 b6606000 r-xp /usr/lib/libunwind.so.8.0.1
b663c000 b6760000 r-xp /lib/libc-2.20-2014.11.so
b6775000 b678e000 r-xp /lib/libgcc_s-4.9.so.1
b679e000 b6880000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b6891000 b68bb000 r-xp /usr/lib/libdbus-1.so.3.8.12
b68cc000 b6908000 r-xp /usr/lib/libsystemd.so.0.4.0
b690a000 b698d000 r-xp /usr/lib/libedje.so.1.13.0
b69a0000 b69be000 r-xp /usr/lib/libecore.so.1.13.0
b69de000 b6b65000 r-xp /usr/lib/libevas.so.1.13.0
b6b9a000 b6bae000 r-xp /lib/libpthread-2.20-2014.11.so
b6bc2000 b6df6000 r-xp /usr/lib/libelementary.so.1.13.0
b6e25000 b6e29000 r-xp /usr/lib/libsmack.so.1.0.0
b6e39000 b6e40000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6e50000 b6e52000 r-xp /usr/lib/libdlog.so.0.0.0
b6e62000 b6e65000 r-xp /usr/lib/libbundle.so.0.1.22
b6e75000 b6e77000 r-xp /lib/libdl-2.20-2014.11.so
b6e88000 b6ea0000 r-xp /usr/lib/libaul.so.0.1.0
b6eb4000 b6eb9000 r-xp /usr/lib/libappcore-efl.so.1.1
b6eca000 b6ed7000 r-xp /usr/lib/liblptcp.so
b6ee9000 b6eed000 r-xp /usr/lib/libsys-assert.so
b6efe000 b6f1e000 r-xp /lib/ld-2.20-2014.11.so
b6f2f000 b6f34000 r-xp /usr/bin/launchpad-loader
b7cda000 b8138000 rw-p [heap]
bef37000 bef58000 rw-p [stack]
End of Maps Information

Callstack Information (PID:21207)
Call Stack Count: 21
 0: _ZN8Hoversel16callback_clickedEPvP10_Eo_OpaqueS0_ + 0x13 (0xb279d358) [/opt/usr/apps/org.example.client/bin/client] + 0x1d358
 1: (0xb6a447ed) [/usr/lib/libevas.so.1] + 0x667ed
 2: (0xb5e8c219) [/usr/lib/libeo.so.1] + 0xb219
 3: eo_event_callback_call + 0x68 (0xb5e8afb9) [/usr/lib/libeo.so.1] + 0x9fb9
 4: evas_object_smart_callback_call + 0x38 (0xb6a45edd) [/usr/lib/libevas.so.1] + 0x67edd
 5: (0xb6961167) [/usr/lib/libedje.so.1] + 0x57167
 6: (0xb6965d87) [/usr/lib/libedje.so.1] + 0x5bd87
 7: (0xb6961b21) [/usr/lib/libedje.so.1] + 0x57b21
 8: (0xb6961ef1) [/usr/lib/libedje.so.1] + 0x57ef1
 9: (0xb6962045) [/usr/lib/libedje.so.1] + 0x58045
10: (0xb69afd11) [/usr/lib/libecore.so.1] + 0xfd11
11: (0xb69abc4b) [/usr/lib/libecore.so.1] + 0xbc4b
12: (0xb69b1a5d) [/usr/lib/libecore.so.1] + 0x11a5d
13: ecore_main_loop_begin + 0x3e (0xb69b1c83) [/usr/lib/libecore.so.1] + 0x11c83
14: appcore_efl_main + 0x20c (0xb6eb72bd) [/usr/lib/libappcore-efl.so.1] + 0x32bd
15: ui_app_main + 0xc0 (0xb3f6d909) [/usr/lib/libcapi-appfw-application.so.0] + 0x2909
16: _ZN6Window10makeWindowEiPPc + 0x11e (0xb279b59f) [/opt/usr/apps/org.example.client/bin/client] + 0x1b59f
17: main + 0x40 (0xb2784ec1) [/opt/usr/apps/org.example.client/bin/client] + 0x4ec1
18: (0xb6f30bb5) [/opt/usr/apps/org.example.client/bin/client] + 0x1bb5
19: __libc_start_main + 0x114 (0xb66524bc) [/lib/libc.so.6] + 0x164bc
20: (0xb6f30eb4) [/opt/usr/apps/org.example.client/bin/client] + 0x1eb4
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
): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.client(21207)
05-31 10:30:40.584+0900 W/AUL     (  612): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 21207, appid: org.example.client, status: fg
05-31 10:30:40.584+0900 I/APP_CORE(21207): appcore-efl.c: __do_app(514) > [APP 21207] Event: RESUME State: CREATED
05-31 10:30:40.594+0900 I/APP_CORE(21207): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
05-31 10:30:40.594+0900 I/APP_CORE(21207): appcore-efl.c: __do_app(625) > [APP 21207] Initial Launching, call the resume_cb
05-31 10:30:40.594+0900 I/CAPI_APPFW_APPLICATION(21207): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
05-31 10:30:40.945+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(21207) status(0)
05-31 10:30:41.245+0900 I/Tizen::App( 1233): (499) > LaunchedApp(org.example.client)
05-31 10:30:41.245+0900 I/Tizen::App( 1233): (733) > Finished invoking application event listener for org.example.client, 21207.
05-31 10:30:41.255+0900 E/RESOURCED(  678): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1243
05-31 10:30:42.016+0900 I/UXT     (21285): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
05-31 10:30:42.546+0900 E/EFL     (21207): ecore_x<21207> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=757161980
05-31 10:30:42.546+0900 I/MY_LOG  (21207): Button pressed
05-31 10:30:42.666+0900 E/EFL     (21207): ecore_x<21207> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=757162102
05-31 10:30:42.676+0900 E/VCONF   (21207): vconf.c: _vconf_check_retry_err(1368) > db/ise/keysound : check retry err (-21/13).
05-31 10:30:42.676+0900 E/VCONF   (21207): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(db/ise/keysound) step(-21) failed(13 / Permission denied) retry(0) 
05-31 10:30:42.676+0900 E/VCONF   (21207): vconf.c: _vconf_get_key(2407) > _vconf_get_key(db/ise/keysound) step(-21) failed(13 / Permission denied)
05-31 10:30:42.676+0900 E/VCONF   (21207): vconf.c: vconf_get_bool(2729) > vconf_get_bool(21207) : db/ise/keysound error
05-31 10:30:42.676+0900 E/VCONF   (21207): vconf-kdb.c: _vconf_kdb_add_notify(318) > _vconf_kdb_add_notify : add noti(Permission denied)
05-31 10:30:42.676+0900 E/VCONF   (21207): vconf.c: vconf_notify_key_changed(3168) > vconf_notify_key_changed : key(db/ise/keysound) add notify fail
05-31 10:30:42.726+0900 I/MY_LOG  (21207): Button unpressed
05-31 10:30:42.756+0900 D/basicui (21207): successed to load edc file
05-31 10:30:42.826+0900 I/MY_LOG  (21207): change
05-31 10:30:44.478+0900 E/EFL     (21207): ecore_x<21207> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=757163916
05-31 10:30:44.488+0900 I/MY_LOG  (21207): Button pressed
05-31 10:30:44.588+0900 E/EFL     (21207): ecore_x<21207> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=757164026
05-31 10:30:44.598+0900 I/MY_LOG  (21207): Button unpressed
05-31 10:30:44.618+0900 E/EFL     (21207): elementary<21207> elc_naviframe.c:1715 _tizen_pop_effect() [DDO]
05-31 10:30:45.579+0900 I/APP_CORE(  867): appcore-efl.c: __do_app(514) > [APP 867] Event: MEM_FLUSH State: PAUSED
05-31 10:30:46.320+0900 E/EFL     (21207): ecore_x<21207> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=757165749
05-31 10:30:46.320+0900 I/MY_LOG  (21207): Button pressed
05-31 10:30:46.400+0900 E/EFL     (21207): ecore_x<21207> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=757165826
05-31 10:30:46.400+0900 I/MY_LOG  (21207): Button unpressed
05-31 10:30:46.950+0900 E/INDICATOR(  676): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
05-31 10:30:46.950+0900 E/INDICATOR(  676): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
05-31 10:30:46.950+0900 E/INDICATOR(  676): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
05-31 10:30:46.950+0900 E/INDICATOR(  676): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
05-31 10:30:46.950+0900 E/INDICATOR(  676): box.c: _update_icon(232) > (!list) -> _update_icon() return
05-31 10:30:46.950+0900 E/INDICATOR(  676): box.c: _update_icon(232) > (!list) -> _update_icon() return
05-31 10:30:46.950+0900 E/INDICATOR(  676): list.c: list_try_to_find_icon_to_remove(378) > (!icon) -> list_try_to_find_icon_to_remove() return
05-31 10:30:46.950+0900 E/INDICATOR(  676): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
05-31 10:30:46.950+0900 E/INDICATOR(  676): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
05-31 10:30:46.950+0900 E/INDICATOR(  676): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
05-31 10:30:46.950+0900 E/INDICATOR(  676): box.c: _update_icon(232) > (!list) -> _update_icon() return
05-31 10:30:46.950+0900 E/INDICATOR(  676): box.c: _update_icon(232) > (!list) -> _update_icon() return
05-31 10:30:47.681+0900 E/EFL     (21207): ecore_x<21207> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=757167116
05-31 10:30:47.691+0900 I/MY_LOG  (21207): Button pressed
05-31 10:30:47.801+0900 E/EFL     (21207): ecore_x<21207> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=757167226
05-31 10:30:47.801+0900 I/MY_LOG  (21207): Button unpressed
05-31 10:30:47.831+0900 D/basicui (21207): successed to load edc file
05-31 10:30:47.861+0900 I/MY_LOG  (21207): change
05-31 10:30:48.962+0900 E/EFL     (21207): ecore_x<21207> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=757168392
05-31 10:30:49.082+0900 E/EFL     (21207): ecore_x<21207> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=757168514
05-31 10:30:50.003+0900 E/EFL     (21207): ecore_x<21207> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=757169437
05-31 10:30:50.134+0900 E/EFL     (21207): ecore_x<21207> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=757169559
05-31 10:30:50.574+0900 E/EFL     (21207): ecore_x<21207> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=757170004
05-31 10:30:50.704+0900 E/EFL     (21207): ecore_x<21207> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=757170137
05-31 10:30:54.258+0900 E/EFL     (21207): ecore_x<21207> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=757173693
05-31 10:30:54.508+0900 E/EFL     (21207): ecore_x<21207> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=757173936
05-31 10:30:54.578+0900 E/EFL     (21207): ecore_x<21207> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=757174016
05-31 10:30:54.578+0900 E/EFL     (  865): ecore_x<865> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=757174016
05-31 10:30:54.588+0900 I/TIZEN_N_SOUND_MANAGER(  865): sound_manager.c: sound_manager_get_current_sound_type(108) > returns : type=-1, ret=0x80000231
05-31 10:30:54.588+0900 E/TIZEN_N_SOUND_MANAGER(  865): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_current_sound_type] NO_PLAYING_SOUND(0xfe6a0003) : core frameworks error code(0x80000231)
05-31 10:30:54.588+0900 W/AUL_AMD (  612): amd_request.c: __request_handler(906) > __request_handler: 14
05-31 10:30:54.598+0900 W/AUL_AMD (  612): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: -1
05-31 10:30:54.608+0900 E/TIZEN_N_SOUND_MANAGER(  865): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_max_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
05-31 10:30:54.678+0900 E/TIZEN_N_SOUND_MANAGER(  865): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_max_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
05-31 10:30:54.688+0900 I/TIZEN_N_SOUND_MANAGER(  865): sound_manager.c: sound_manager_get_volume(84) > returns : type=3, volume=0, ret=0x0
05-31 10:30:54.688+0900 E/TIZEN_N_SOUND_MANAGER(  865): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
05-31 10:30:54.688+0900 I/TIZEN_N_SOUND_MANAGER(  865): sound_manager_product.c: sound_manager_get_active_route(1121) > type[1](0:in,1:out,2:in/out), route[100]
05-31 10:30:54.688+0900 E/TIZEN_N_SOUND_MANAGER(  865): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_active_route] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
05-31 10:30:54.698+0900 I/TIZEN_N_SOUND_MANAGER(  865): sound_manager.c: sound_manager_get_volume(84) > returns : type=3, volume=0, ret=0x0
05-31 10:30:54.698+0900 E/TIZEN_N_SOUND_MANAGER(  865): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
05-31 10:30:54.698+0900 W/APP_CORE(  865): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:3c00007
05-31 10:30:54.718+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(865) status(0)
05-31 10:30:54.728+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(865) status(3)
05-31 10:30:54.728+0900 W/AUL_AMD (  612): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
05-31 10:30:54.728+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
05-31 10:30:54.728+0900 I/APP_CORE(  865): appcore-efl.c: __do_app(514) > [APP 865] Event: RESUME State: PAUSED
05-31 10:30:54.728+0900 I/CAPI_APPFW_APPLICATION(  865): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
05-31 10:30:54.738+0900 E/EFL     (21207): ecore_x<21207> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=757174170
05-31 10:30:55.118+0900 W/AUL     (21293): launch.c: app_request_to_launchpad(396) > request cmd(0) to(org.tizen.poweroff-syspopup)
05-31 10:30:55.118+0900 W/AUL_AMD (  612): amd_request.c: __request_handler(906) > __request_handler: 0
05-31 10:30:55.128+0900 I/AUL     (  612): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/popup-launcher, ret : 0
05-31 10:30:55.138+0900 I/AUL     (  612): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/dbus-daemon, ret : 0
05-31 10:30:55.138+0900 E/AUL_AMD (  612): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
05-31 10:30:55.138+0900 W/AUL_AMD (  612): amd_launch.c: _start_app(2508) > caller pid : 21293
05-31 10:30:55.138+0900 E/AUL_AMD (  612): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
05-31 10:30:55.148+0900 E/RESOURCED(  678): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
05-31 10:30:55.148+0900 W/AUL_AMD (  612): amd_launch.c: _start_app(3052) > pad pid(-5)
05-31 10:30:55.148+0900 W/AUL_PAD ( 1497): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
05-31 10:30:55.148+0900 W/AUL_PAD ( 1497): launchpad.c: __send_result_to_caller(267) > Check app launching
05-31 10:30:55.178+0900 E/VCONF   (17295): vconf.c: _vconf_check_install_key_list(1135) > key : memory/setup_wizard/state
05-31 10:30:55.178+0900 E/VCONF   (17295): vconf.c: _vconf_check_retry_err(1368) > memory/setup_wizard/state : check retry err (-21/2).
05-31 10:30:55.178+0900 E/VCONF   (17295): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(memory/setup_wizard/state) step(-21) failed(2 / No such file or directory) retry(0) 
05-31 10:30:55.178+0900 E/VCONF   (17295): vconf.c: _vconf_get_key(2407) > _vconf_get_key(memory/setup_wizard/state) step(-21) failed(2 / No such file or directory)
05-31 10:30:55.178+0900 E/VCONF   (17295): vconf.c: vconf_get_int(2650) > vconf_get_int(17295) : memory/setup_wizard/state error
05-31 10:30:55.178+0900 E/VCONF   (17295): vconf.c: _vconf_check_install_key_list(1135) > key : db/setting/accessibility/accessibility
05-31 10:30:55.178+0900 E/VCONF   (17295): vconf.c: _vconf_check_retry_err(1368) > db/setting/accessibility/accessibility : check retry err (-21/2).
05-31 10:30:55.178+0900 E/VCONF   (17295): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(db/setting/accessibility/accessibility) step(-21) failed(2 / No such file or directory) retry(0) 
05-31 10:30:55.178+0900 E/VCONF   (17295): vconf.c: _vconf_get_key(2407) > _vconf_get_key(db/setting/accessibility/accessibility) step(-21) failed(2 / No such file or directory)
05-31 10:30:55.178+0900 E/VCONF   (17295): vconf.c: vconf_get_bool(2729) > vconf_get_bool(17295) : db/setting/accessibility/accessibility error
05-31 10:30:55.178+0900 E/VCONF   (17295): vconf.c: _vconf_check_install_key_list(1135) > key : memory/setup_wizard/state
05-31 10:30:55.178+0900 E/VCONF   (17295): vconf.c: _vconf_check_retry_err(1368) > memory/setup_wizard/state : check retry err (-21/2).
05-31 10:30:55.178+0900 E/VCONF   (17295): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(memory/setup_wizard/state) step(-21) failed(2 / No such file or directory) retry(0) 
05-31 10:30:55.178+0900 E/VCONF   (17295): vconf.c: _vconf_get_key(2407) > _vconf_get_key(memory/setup_wizard/state) step(-21) failed(2 / No such file or directory)
05-31 10:30:55.178+0900 E/VCONF   (17295): vconf.c: vconf_get_int(2650) > vconf_get_int(17295) : memory/setup_wizard/state error
05-31 10:30:55.178+0900 E/VCONF   (17295): vconf.c: _vconf_check_install_key_list(1135) > key : memory/setup_wizard/state
05-31 10:30:55.178+0900 E/VCONF   (17295): vconf.c: _vconf_check_retry_err(1368) > memory/setup_wizard/state : check retry err (-21/2).
05-31 10:30:55.178+0900 E/VCONF   (17295): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(memory/setup_wizard/state) step(-21) failed(2 / No such file or directory) retry(0) 
05-31 10:30:55.178+0900 E/VCONF   (17295): vconf.c: _vconf_get_key(2407) > _vconf_get_key(memory/setup_wizard/state) step(-21) failed(2 / No such file or directory)
05-31 10:30:55.178+0900 E/VCONF   (17295): vconf.c: vconf_get_int(2650) > vconf_get_int(17295) : memory/setup_wizard/state error
05-31 10:30:55.178+0900 E/VCONF   (17295): vconf.c: _vconf_check_install_key_list(1135) > key : memory/setup_wizard/state
05-31 10:30:55.178+0900 E/VCONF   (17295): vconf.c: _vconf_check_retry_err(1368) > memory/setup_wizard/state : check retry err (-21/2).
05-31 10:30:55.178+0900 E/VCONF   (17295): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(memory/setup_wizard/state) step(-21) failed(2 / No such file or directory) retry(0) 
05-31 10:30:55.178+0900 E/VCONF   (17295): vconf.c: _vconf_get_key(2407) > _vconf_get_key(memory/setup_wizard/state) step(-21) failed(2 / No such file or directory)
05-31 10:30:55.178+0900 E/VCONF   (17295): vconf.c: vconf_get_int(2650) > vconf_get_int(17295) : memory/setup_wizard/state error
05-31 10:30:55.178+0900 E/VCONF   (17295): vconf.c: _vconf_check_install_key_list(1135) > key : memory/setup_wizard/state
05-31 10:30:55.178+0900 E/VCONF   (17295): vconf.c: _vconf_check_retry_err(1368) > memory/setup_wizard/state : check retry err (-21/2).
05-31 10:30:55.178+0900 E/VCONF   (17295): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(memory/setup_wizard/state) step(-21) failed(2 / No such file or directory) retry(0) 
05-31 10:30:55.178+0900 E/VCONF   (17295): vconf.c: _vconf_get_key(2407) > _vconf_get_key(memory/setup_wizard/state) step(-21) failed(2 / No such file or directory)
05-31 10:30:55.178+0900 E/VCONF   (17295): vconf.c: vconf_get_int(2650) > vconf_get_int(17295) : memory/setup_wizard/state error
05-31 10:30:55.208+0900 I/TIZEN_N_SOUND_MANAGER(  865): sound_manager.c: sound_manager_get_volume(84) > returns : type=3, volume=0, ret=0x0
05-31 10:30:55.208+0900 E/TIZEN_N_SOUND_MANAGER(  865): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
05-31 10:30:55.249+0900 W/AUL     (  612): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 17295, appid: org.tizen.poweroff-syspopup
05-31 10:30:55.249+0900 E/AUL     (  612): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
05-31 10:30:55.249+0900 W/AUL     (21293): launch.c: app_request_to_launchpad(425) > request cmd(0) result(17295)
05-31 10:30:55.259+0900 I/APP_CORE(17295): appcore-efl.c: __do_app(514) > [APP 17295] Event: RESET State: CREATED
05-31 10:30:55.259+0900 E/RESOURCED(  678): proc-main.c: proc_add_program_list(237) > not found ppi : org.tizen.poweroff-syspopup
05-31 10:30:55.309+0900 I/TIZEN_N_SOUND_MANAGER(  865): sound_manager.c: sound_manager_get_volume(84) > returns : type=3, volume=0, ret=0x0
05-31 10:30:55.309+0900 E/TIZEN_N_SOUND_MANAGER(  865): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
05-31 10:30:55.349+0900 I/GXT_SIB (17295): gxt_shared_image_buffer.c: gxt_shared_image_buffer_initialize(113) > [Shared Image Buffer] flink_id=5
05-31 10:30:55.379+0900 E/EFL     (  335): eo<335> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
05-31 10:30:55.379+0900 E/EFL     (  335): eo<335> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
05-31 10:30:55.389+0900 E/EFL     (17295): edje<17295> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
05-31 10:30:55.389+0900 E/EFL     (17295): By the power of Grayskull, your previous Embryo stack is now broken!
05-31 10:30:55.399+0900 I/Tizen::System( 1233): (259) > Active app [org.tizen.], current [org.exampl] 
05-31 10:30:55.399+0900 I/Tizen::Io( 1233): (729) > Entry not found
05-31 10:30:55.399+0900 I/Tizen::System( 1233): (157) > change brightness system value.
05-31 10:30:55.399+0900 W/APP_CORE(17295): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:5800009
05-31 10:30:55.409+0900 W/AUL_AMD (  612): amd_request.c: __request_handler(906) > __request_handler: 35
05-31 10:30:55.409+0900 I/TIZEN_N_SOUND_MANAGER(  865): sound_manager.c: sound_manager_get_volume(84) > returns : type=3, volume=0, ret=0x0
05-31 10:30:55.409+0900 E/TIZEN_N_SOUND_MANAGER(  865): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
05-31 10:30:55.409+0900 I/TIZEN_N_SOUND_MANAGER(  913): sound_manager.c: sound_manager_get_volume(84) > returns : type=0, volume=9, ret=0x0
05-31 10:30:55.409+0900 E/TIZEN_N_SOUND_MANAGER(  913): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
05-31 10:30:55.419+0900 I/TIZEN_N_SOUND_MANAGER(  913): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=15, ret=0x0
05-31 10:30:55.419+0900 E/TIZEN_N_SOUND_MANAGER(  913): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
05-31 10:30:55.419+0900 W/AUL_AMD (  612): amd_request.c: __request_handler(906) > __request_handler: 15
05-31 10:30:55.509+0900 I/TIZEN_N_SOUND_MANAGER(  865): sound_manager.c: sound_manager_get_volume(84) > returns : type=3, volume=0, ret=0x0
05-31 10:30:55.509+0900 E/TIZEN_N_SOUND_MANAGER(  865): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
05-31 10:30:55.509+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(17295) status(0)
05-31 10:30:55.519+0900 I/APP_CORE(17295): appcore-efl.c: __do_app(514) > [APP 17295] Event: RESUME State: CREATED
05-31 10:30:55.519+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(17295) status(3)
05-31 10:30:55.519+0900 W/AUL_AMD (  612): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
05-31 10:30:55.519+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
05-31 10:30:55.519+0900 W/AUL     (  612): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.tizen.poweroff-syspopup(17295)
05-31 10:30:55.519+0900 W/AUL     (  612): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 17295, appid: org.tizen.poweroff-syspopup, status: fg
05-31 10:30:55.529+0900 I/APP_CORE(17295): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
05-31 10:30:55.529+0900 I/APP_CORE(17295): appcore-efl.c: __do_app(625) > [APP 17295] Initial Launching, call the resume_cb
05-31 10:30:55.609+0900 I/TIZEN_N_SOUND_MANAGER(  865): sound_manager.c: sound_manager_get_volume(84) > returns : type=3, volume=0, ret=0x0
05-31 10:30:55.609+0900 E/TIZEN_N_SOUND_MANAGER(  865): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
05-31 10:30:55.709+0900 I/TIZEN_N_SOUND_MANAGER(  865): sound_manager.c: sound_manager_get_volume(84) > returns : type=3, volume=0, ret=0x0
05-31 10:30:55.709+0900 E/TIZEN_N_SOUND_MANAGER(  865): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
05-31 10:30:55.809+0900 I/TIZEN_N_SOUND_MANAGER(  865): sound_manager.c: sound_manager_get_volume(84) > returns : type=3, volume=0, ret=0x0
05-31 10:30:55.809+0900 E/TIZEN_N_SOUND_MANAGER(  865): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
05-31 10:30:55.909+0900 I/TIZEN_N_SOUND_MANAGER(  865): sound_manager.c: sound_manager_get_volume(84) > returns : type=3, volume=0, ret=0x0
05-31 10:30:55.909+0900 E/TIZEN_N_SOUND_MANAGER(  865): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
05-31 10:30:55.969+0900 E/EFL     (21207): ecore_x<21207> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=757175407
05-31 10:30:55.969+0900 E/EFL     (  865): ecore_x<865> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=757175407
05-31 10:30:56.039+0900 E/EFL     (21207): ecore_x<21207> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=757175472
05-31 10:30:56.300+0900 I/Tizen::App( 1233): (499) > LaunchedApp(org.tizen.poweroff-syspopup)
05-31 10:30:56.300+0900 I/Tizen::App( 1233): (733) > Finished invoking application event listener for org.tizen.poweroff-syspopup, 17295.
05-31 10:30:56.310+0900 E/RESOURCED(  678): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1251
05-31 10:30:56.700+0900 E/VOLUME  (  865): volume_x_event.c: _event_handler_cb(147) > [_event_handler_cb:147] _event_handler_cb, 22
05-31 10:30:56.700+0900 E/EFL     (17295): ecore_x<17295> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=757176137
05-31 10:30:56.770+0900 E/EFL     (17295): ecore_x<17295> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=757176203
05-31 10:30:56.790+0900 W/AUL_AMD (  612): amd_request.c: __request_handler(906) > __request_handler: 22
05-31 10:30:56.790+0900 W/AUL_AMD (  612): amd_request.c: __request_handler(1201) > app status : 5
05-31 10:30:56.790+0900 W/AUL     (  612): amd_app_group.c: __set_fg_flag(190) > send_signal BG org.tizen.poweroff-syspopup(17295)
05-31 10:30:56.790+0900 W/AUL     (  612): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 17295, appid: org.tizen.poweroff-syspopup, status: bg
05-31 10:30:56.790+0900 E/EFL     (  335): eo<335> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
05-31 10:30:56.800+0900 E/EFL     (17295): eo<17295> lib/eo/eo.c:676 _eo_call_resolve() in elm_widget.eo.c:11: func 'elm_obj_widget_focus_get' (337) could not be resolved for class 'Edje_Object'.
05-31 10:30:56.800+0900 E/EFL     (17295): eo<17295> lib/eo/eo.c:676 _eo_call_resolve() in elm_widget.eo.c:11: func 'elm_obj_widget_focus_get' (337) could not be resolved for class 'Edje_Object'.
05-31 10:30:56.800+0900 E/EFL     (  335): eo<335> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
05-31 10:30:56.820+0900 W/AUL_AMD (  612): amd_request.c: __request_handler(906) > __request_handler: 15
05-31 10:30:56.840+0900 I/Tizen::System( 1233): (259) > Active app [org.exampl], current [org.tizen.] 
05-31 10:30:56.840+0900 I/Tizen::Io( 1233): (729) > Entry not found
05-31 10:30:56.850+0900 I/Tizen::System( 1233): (157) > change brightness system value.
05-31 10:30:56.850+0900 E/EFL     (21207): ecore_x<21207> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=757176281
05-31 10:30:56.880+0900 I/MALI    (17295): egl_platform_x11.c: __egl_platform_terminate(358) > [EGL-X11] PID=17295   close drm_fd=30 
05-31 10:30:56.920+0900 E/EFL     (21207): ecore_x<21207> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=757176358
05-31 10:30:57.020+0900 W/APP_CORE(  865): appcore-efl.c: __hide_cb(943) > [EVENT_TEST][EVENT] GET HIDE EVENT!!!. WIN:3c00007
05-31 10:30:57.020+0900 I/APP_CORE(  865): appcore-efl.c: __do_app(514) > [APP 865] Event: PAUSE State: RUNNING
05-31 10:30:57.020+0900 I/CAPI_APPFW_APPLICATION(  865): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
05-31 10:30:57.090+0900 I/AUL_PAD ( 1497): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 17295 pgid = 17295
05-31 10:30:57.090+0900 I/AUL_PAD ( 1497): sigchild.h: __sigchild_action(143) > dead_pid(17295)
05-31 10:30:57.120+0900 I/AUL_PAD ( 1497): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
05-31 10:30:57.120+0900 I/AUL_PAD ( 1497): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
05-31 10:30:57.120+0900 E/AUL_PAD ( 1497): launchpad.c: main(698) > error reading sigchld info
05-31 10:30:57.120+0900 I/ESD     (  894): esd_main.c: __esd_app_dead_handler(1773) > pid: 17295
05-31 10:30:57.120+0900 I/Tizen::App( 1233): (243) > App[org.tizen.poweroff-syspopup] pid[17295] terminate event is forwarded
05-31 10:30:57.120+0900 I/Tizen::System( 1233): (256) > osp.accessorymanager.service provider is found.
05-31 10:30:57.120+0900 I/Tizen::System( 1233): (196) > Accessory Owner is removed [org.tizen.poweroff-syspopup, 17295, ]
05-31 10:30:57.120+0900 I/Tizen::System( 1233): (256) > osp.system.service provider is found.
05-31 10:30:57.120+0900 I/Tizen::App( 1233): (506) > TerminatedApp(org.tizen.poweroff-syspopup)
05-31 10:30:57.120+0900 I/Tizen::App( 1233): (512) > Not registered pid(17295)
05-31 10:30:57.120+0900 I/Tizen::System( 1233): (246) > Terminated app [org.tizen.poweroff-syspopup]
05-31 10:30:57.120+0900 I/Tizen::Io( 1233): (729) > Entry not found
05-31 10:30:57.120+0900 W/AUL_AMD (  612): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 17295
05-31 10:30:57.120+0900 W/AUL_AMD (  612): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 17295
05-31 10:30:57.130+0900 E/RESOURCED(  678): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1254
05-31 10:30:57.130+0900 I/Tizen::System( 1233): (157) > change brightness system value.
05-31 10:30:57.130+0900 I/Tizen::App( 1233): (782) > Finished invoking application event listener for org.tizen.poweroff-syspopup, 17295.
05-31 10:30:57.180+0900 I/UXT     (21300): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
05-31 10:30:57.220+0900 E/TBM     (21300): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
05-31 10:30:57.220+0900 I/MALI    (21300): egl_platform_x11.c: __egl_platform_initialize(242) > [EGL-X11] PID=21300   open drm_fd=30 
05-31 10:30:57.331+0900 E/EFL     (21300): edje<21300> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
05-31 10:30:57.331+0900 E/EFL     (21300): By the power of Grayskull, your previous Embryo stack is now broken!
05-31 10:30:57.331+0900 E/EFL     (21300): edje<21300> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
05-31 10:30:57.331+0900 E/EFL     (21300): By the power of Grayskull, your previous Embryo stack is now broken!
05-31 10:30:57.331+0900 E/EFL     (21300): edje<21300> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
05-31 10:30:57.331+0900 E/EFL     (21300): By the power of Grayskull, your previous Embryo stack is now broken!
05-31 10:30:59.112+0900 E/EFL     (21207): ecore_x<21207> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=757178542
05-31 10:30:59.182+0900 E/EFL     (21207): ecore_x<21207> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=757178613
05-31 10:30:59.182+0900 E/EFL     (21207): ecore_x<21207> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=757178613
05-31 10:30:59.182+0900 E/EFL     (21207): ecore_x<21207> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=757178613
05-31 10:30:59.623+0900 E/VCONF   (  335): vconf.c: vconf_get_int(2657) > The type(43) of keynode(db/setting/sound/sound_on) is not INT
05-31 10:31:00.193+0900 I/INDICATOR(  676): clock.c: indicator_clock_changed_cb(195) > ""
05-31 10:31:00.203+0900 E/UXT     (  676): uxt_util.c: uxt_util_get_date_time_text_by_locale(389) > text : 오전 10:31
05-31 10:31:00.203+0900 I/INDICATOR(  676): clock.c: getTimeFormatted(176) > "time format : 오전 10:31"
05-31 10:31:00.203+0900 I/INDICATOR(  676): clock.c: indicator_clock_changed_cb(244) > "time format : 오전 10:31"
05-31 10:31:00.203+0900 W/INDICATOR(  676): clock.c: indicator_clock_changed_cb(272) > 
05-31 10:31:00.203+0900 I/INDICATOR(  676): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2146081109 Time: <font_size=31> </font_size> <font_size=31> 오전 10:31</font_size></font>"
05-31 10:31:00.474+0900 I/CAPI_CONTENT_MEDIA_CONTENT(  335): media_content.c: media_content_connect(856) > [32m[335]ref count : 0
05-31 10:31:00.484+0900 I/CAPI_CONTENT_MEDIA_CONTENT(  335): media_content.c: media_content_connect(888) > [32m[335]ref count changed to: 1
05-31 10:31:00.494+0900 W/MEDIA_SERVER_THUMB(  890): media-server-thumb.c: _ms_thumb_request_to_server(825) > Thumb server is not running.. so start it
05-31 10:31:00.704+0900 E/MEDIA_UTIL(  890): media-util-ipc.c: __make_rand_sock_and_bind(76) > bind failed : STANDARD ERROR [Address already in use]
05-31 10:31:00.704+0900 E/MEDIA_UTIL(  890): media-util-ipc.c: __make_rand_sock_and_bind(83) > [31mretry bind 0
05-31 10:31:00.714+0900 E/MEDIA_THUMBNAIL(21307): media-thumb-db.c: _media_thumb_get_thumb_path_from_db(162) > [31mend of row [unknown error]
05-31 10:31:00.714+0900 W/MEDIA_THUMBNAIL(21307): media-thumb-db.c: _media_thumb_get_thumb_from_db_with_size(408) > [32mOriginal path doesn't exist in DB
05-31 10:31:00.874+0900 I/SYNCSERVICE(  958): SyncManager_DataChangeSyncScheduler.cpp: OnMediaContentDataChanged(71) > On Media Content Data Changed
05-31 10:31:00.874+0900 I/CAPI_CONTENT_MEDIA_CONTENT(  335): media_content.c: media_content_disconnect(940) > [32m[335]ref count changed to: 0
05-31 10:31:00.874+0900 I/SYNCSERVICE(  958): SyncManager_DataChangeSyncScheduler.cpp: OnMediaContentDataChanged(79) > Media Content Image Type Data Changed
05-31 10:31:00.874+0900 I/SYNCSERVICE(  958): SyncManager_DataChangeSyncScheduler.cpp: HandleDataChangeEvent(332) > DataChangeSyncScheduler::HandleDataChangeEvent() Starts
05-31 10:31:00.874+0900 I/SYNCSERVICE(  958): SyncManager_SyncManager.cpp: SendSyncCheckAlarmMessage(1018) > Fire SYNC_CHECK_ALARM 
05-31 10:31:00.874+0900 I/SYNCSERVICE(  958): SyncManager_SyncWorker.cpp: AddRequestN(137) > Adding a request to sync worker
05-31 10:31:00.874+0900 I/SYNCSERVICE(  958): SyncManager_SyncWorker.cpp: AddRequestN(152) > Added into __pendingRequests, current size = 1
05-31 10:31:00.874+0900 I/SYNCSERVICE(  958): SyncManager_SyncWorker.cpp: AddRequestN(164) > Request Successfully added
05-31 10:31:00.874+0900 I/SYNCSERVICE(  958): SyncManager_DataChangeSyncScheduler.cpp: HandleDataChangeEvent(345) > DataChangeSyncScheduler::HandleDataChangeEvent() Ends
05-31 10:31:00.874+0900 I/SYNCSERVICE(  958): SyncManager_SyncWorker.cpp: OnEventReceived(175) > GIO event received
05-31 10:31:00.874+0900 I/SYNCSERVICE(  958): SyncManager_SyncWorker.cpp: OnEventReceived(201) > Popping from __pendingRequests, size = 0
05-31 10:31:00.874+0900 I/SYNCSERVICE(  958): SyncManager_SyncJobDispatcher.cpp: OnEventReceived(127) > 0. Sync Job dispatcher starts
05-31 10:31:00.874+0900 I/SYNCSERVICE(  958): SyncManager_SyncJobDispatcher.cpp: OnEventReceived(157) > 1. Handle Event : SYNC_CHECK_ALARM
05-31 10:31:00.874+0900 I/SYNCSERVICE(  958): SyncManager_SyncJobDispatcher.cpp: OnEventReceived(158) > 2. Start next Sync job from main queue
05-31 10:31:00.874+0900 I/SYNCSERVICE(  958): SyncManager_SyncJobDispatcher.cpp: TryStartingNextJobLocked(221) > SyncJob Queues are empty
05-31 10:31:00.874+0900 I/SYNCSERVICE(  958): SyncManager_SyncJobDispatcher.cpp: OnEventReceived(174) > 3. Sync Job dispatcher Ends
05-31 10:31:00.874+0900 I/SYNCSERVICE(  958): SyncManager_SyncWorker.cpp: OnEventReceived(214) > Event handled successfully
05-31 10:31:00.884+0900 I/AUL     (  335): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/enlightenment, ret : 0
05-31 10:31:00.894+0900 I/AUL     (  335): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/enlightenment, ret : 0
05-31 10:31:00.904+0900 I/AUL     (  335): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/enlightenment, ret : 0
05-31 10:31:00.904+0900 I/AUL     (  335): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/enlightenment, ret : 0
05-31 10:31:00.904+0900 E/CAPI_APPFW_APP_MANAGER(  335): app_manager.c: app_manager_error(74) > [app_manager_get_app_id] Invalid parameter(0xffffffea) : Invalid process ID
05-31 10:31:00.924+0900 I/AUL     (  806): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/data-provider-master, ret : 0
05-31 10:31:00.934+0900 I/AUL     (  806): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/data-provider-master, ret : 0
05-31 10:31:00.934+0900 I/AUL     (  806): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/data-provider-master, ret : 0
05-31 10:31:00.944+0900 I/AUL     (  806): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/data-provider-master, ret : 0
05-31 10:31:00.944+0900 E/CAPI_APPFW_APP_MANAGER(  806): app_manager.c: app_manager_error(74) > [app_manager_get_app_id] Invalid parameter(0xffffffea) : Invalid process ID
05-31 10:31:00.994+0900 E/QUICKPANEL(  866): NotificationItemModel.cpp: __playSound(1805) > [0;31m* Critical * None type: No sound[0;m
05-31 10:31:00.994+0900 I/QUICKPANEL(  866): NotificationItemModel.cpp: __updateSmartAlert(2308) > [0;32mpackage name: shot-tizen, insert: 1[0;m
05-31 10:31:01.004+0900 E/QUICKPANEL(  866): NotificationItemControl.cpp: __isIconAnimated(670) > [0;31m* Critical * object doesn't exist.[0;m
05-31 10:31:01.004+0900 E/QUICKPANEL(  866): NotificationItemControl.cpp: __isIconAnimated(670) > [0;31m* Critical * object doesn't exist.[0;m
05-31 10:31:01.014+0900 E/QUICKPANEL(  866): NotificationItemControl.cpp: __isIconAnimated(670) > [0;31m* Critical * object doesn't exist.[0;m
05-31 10:31:01.014+0900 W/QUICKPANEL(  866): NotificationItemModel.cpp: __addNotification(637) > [0;35mshot-tizen - notification is inserted.[0;m
05-31 10:31:01.014+0900 E/INDICATOR(  676): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
05-31 10:31:01.014+0900 E/INDICATOR(  676): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
05-31 10:31:01.014+0900 E/INDICATOR(  676): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
05-31 10:31:01.014+0900 E/INDICATOR(  676): box.c: _update_icon(232) > (!list) -> _update_icon() return
05-31 10:31:01.014+0900 E/INDICATOR(  676): box.c: _update_icon(232) > (!list) -> _update_icon() return
05-31 10:31:01.014+0900 E/INDICATOR(  676): ticker.c: _ticker_noti_detailed_changed_cb(1411) > ERROR
05-31 10:31:01.024+0900 I/QUICKPANEL(  866): ScrollContainerViManager.cpp: startAnimation(74) > [0;32mAnimation is started.[0;m
05-31 10:31:01.024+0900 W/QUICKPANEL(  866): NotificationItemModel.cpp: insertNotification(237) > [0;35mEvent notification is inserted.[0;m
05-31 10:31:01.024+0900 E/EFL     (  866): eo<866> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (724) could not be resolved for class 'Elm_Layout'.
05-31 10:31:01.024+0900 I/QUICKPANEL(  866): ScrollContainerViManager.cpp: __onAnimationFinished(465) > [0;32mAnimation is finished.[0;m
05-31 10:31:01.044+0900 E/EFL     (  866): edje<866> lib/edje/edje_util.c:3568 _edje_object_size_min_restricted_calc() file /usr/apps/com.samsung.quickpanel/res/edje/quickpanel.edj, group quickpanel/listitem/notification has a non-fixed part 'elm.text.time'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-31 10:31:01.795+0900 W/AUL_AMD (  612): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
05-31 10:31:02.035+0900 I/APP_CORE(  865): appcore-efl.c: __do_app(514) > [APP 865] Event: MEM_FLUSH State: PAUSED
05-31 10:31:05.569+0900 W/MEDIA_THUMBNAIL_SERVER(21307): thumb-server-internal.c: _thumb_server_read_socket(514) > [32mreceived KILL msg from thumbnail agent.
05-31 10:31:05.569+0900 W/MEDIA_THUMBNAIL_SERVER(21307): thumb-server-internal.c: _thumb_server_read_socket(575) > [32mShutting down...
05-31 10:31:05.569+0900 E/MEDIA_THUMBNAIL_DCM(21307): thumb-server-dcm.c: _thumb_server_dcm_quit_main_loop(445) > [31mInvalid DCM thread main loop![0m
05-31 10:31:05.739+0900 E/MEDIA_SERVER(  890): media-server-main.c: _ms_signal_handler(183) > [21307] Thumbnail server is stopped by media-server
05-31 10:31:05.739+0900 E/MEDIA_SERVER_THUMB(  890): media-server-thumb.c: ms_thumb_reset_server_status(162) > [no-err] g_thumb_server_extracting = 0 -> FALSE
05-31 10:31:07.430+0900 E/INDICATOR(  676): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
05-31 10:31:07.430+0900 E/INDICATOR(  676): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
05-31 10:31:07.430+0900 E/INDICATOR(  676): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
05-31 10:31:07.430+0900 E/INDICATOR(  676): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
05-31 10:31:07.440+0900 E/INDICATOR(  676): box.c: _update_icon(232) > (!list) -> _update_icon() return
05-31 10:31:07.440+0900 E/INDICATOR(  676): box.c: _update_icon(232) > (!list) -> _update_icon() return
05-31 10:31:07.440+0900 E/INDICATOR(  676): list.c: list_try_to_find_icon_to_remove(378) > (!icon) -> list_try_to_find_icon_to_remove() return
05-31 10:31:07.440+0900 E/INDICATOR(  676): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
05-31 10:31:07.440+0900 E/INDICATOR(  676): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
05-31 10:31:07.440+0900 E/INDICATOR(  676): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
05-31 10:31:07.440+0900 E/INDICATOR(  676): box.c: _update_icon(232) > (!list) -> _update_icon() return
05-31 10:31:07.440+0900 E/INDICATOR(  676): box.c: _update_icon(232) > (!list) -> _update_icon() return
05-31 10:31:39.452+0900 E/EFL     (21207): ecore_x<21207> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=757218881
05-31 10:31:39.732+0900 E/EFL     (21207): ecore_x<21207> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=757219158
05-31 10:31:40.082+0900 E/EFL     (21207): ecore_x<21207> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=757219513
05-31 10:31:40.262+0900 E/EFL     (21207): ecore_x<21207> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=757219690
05-31 10:32:00.222+0900 I/INDICATOR(  676): clock.c: indicator_clock_changed_cb(195) > ""
05-31 10:32:00.222+0900 E/UXT     (  676): uxt_util.c: uxt_util_get_date_time_text_by_locale(389) > text : 오전 10:32
05-31 10:32:00.222+0900 I/INDICATOR(  676): clock.c: getTimeFormatted(176) > "time format : 오전 10:32"
05-31 10:32:00.222+0900 I/INDICATOR(  676): clock.c: indicator_clock_changed_cb(244) > "time format : 오전 10:32"
05-31 10:32:00.222+0900 W/INDICATOR(  676): clock.c: indicator_clock_changed_cb(272) > 
05-31 10:32:00.222+0900 I/INDICATOR(  676): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2146043147 Time: <font_size=31> </font_size> <font_size=31> 오전 10:32</font_size></font>"
05-31 10:33:00.280+0900 I/INDICATOR(  676): clock.c: indicator_clock_changed_cb(195) > ""
05-31 10:33:00.280+0900 E/UXT     (  676): uxt_util.c: uxt_util_get_date_time_text_by_locale(389) > text : 오전 10:33
05-31 10:33:00.280+0900 I/INDICATOR(  676): clock.c: getTimeFormatted(176) > "time format : 오전 10:33"
05-31 10:33:00.280+0900 I/INDICATOR(  676): clock.c: indicator_clock_changed_cb(244) > "time format : 오전 10:33"
05-31 10:33:00.280+0900 W/INDICATOR(  676): clock.c: indicator_clock_changed_cb(272) > 
05-31 10:33:00.280+0900 I/INDICATOR(  676): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2146036487 Time: <font_size=31> </font_size> <font_size=31> 오전 10:33</font_size></font>"
05-31 10:33:41.090+0900 E/EFL     (21207): ecore_x<21207> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=757340524
05-31 10:33:41.180+0900 E/EFL     (21207): ecore_x<21207> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=757340613
05-31 10:33:41.651+0900 E/EFL     (21207): ecore_x<21207> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=757341087
05-31 10:33:41.781+0900 E/EFL     (21207): ecore_x<21207> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=757341208
05-31 10:33:42.131+0900 E/EFL     (21207): ecore_x<21207> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=757341558
05-31 10:33:42.271+0900 E/EFL     (21207): ecore_x<21207> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=757341702
05-31 10:33:42.952+0900 E/EFL     (21207): ecore_x<21207> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=757342387
05-31 10:33:42.962+0900 I/MY_LOG  (21207): Button pressed
05-31 10:33:43.092+0900 E/EFL     (21207): ecore_x<21207> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=757342519
05-31 10:33:43.092+0900 I/MY_LOG  (21207): Button unpressed
05-31 10:33:43.102+0900 I/basicui (21207): (selected item : DEFAULT)
05-31 10:33:44.163+0900 E/EFL     (21207): ecore_x<21207> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=757343596
05-31 10:33:44.163+0900 I/MY_LOG  (21207): Button pressed
05-31 10:33:44.253+0900 E/EFL     (21207): ecore_x<21207> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=757343684
05-31 10:33:44.253+0900 I/MY_LOG  (21207): Button unpressed
05-31 10:33:44.263+0900 I/basicui (21207): (selected item : DEFAULT)
05-31 10:33:44.364+0900 E/EFL     (21207): ecore_x<21207> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=757343795
05-31 10:33:44.364+0900 I/MY_LOG  (21207): Button pressed
05-31 10:33:44.454+0900 E/EFL     (21207): ecore_x<21207> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=757343883
05-31 10:33:44.454+0900 I/MY_LOG  (21207): Button unpressed
05-31 10:33:44.464+0900 I/basicui (21207): (selected item : DEFAULT)
05-31 10:33:44.764+0900 E/EFL     (21207): ecore_x<21207> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=757344192
05-31 10:33:44.864+0900 E/EFL     (21207): ecore_x<21207> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=757344291
05-31 10:33:45.124+0900 I/AUL_PAD ( 1497): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 21207 pgid = 21207
05-31 10:33:45.124+0900 I/AUL_PAD ( 1497): sigchild.h: __sigchild_action(143) > dead_pid(21207)
05-31 10:33:45.124+0900 E/EFL     (  335): eo<335> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
05-31 10:33:45.154+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(867) status(3)
05-31 10:33:45.154+0900 W/AUL_AMD (  612): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
05-31 10:33:45.154+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
05-31 10:33:45.154+0900 W/AUL     (  612): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(867)
05-31 10:33:45.154+0900 W/AUL     (  612): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 867, appid: com.samsung.homescreen, status: fg
05-31 10:33:45.174+0900 I/AUL_PAD ( 1497): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
05-31 10:33:45.174+0900 I/AUL_PAD ( 1497): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
05-31 10:33:45.174+0900 E/AUL_PAD ( 1497): launchpad.c: main(698) > error reading sigchld info
05-31 10:33:45.184+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(867) status(0)
05-31 10:33:45.194+0900 I/APP_CORE(  867): appcore-efl.c: __do_app(514) > [APP 867] Event: RESUME State: PAUSED
05-31 10:33:45.194+0900 I/CAPI_APPFW_APPLICATION(  867): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
05-31 10:33:45.194+0900 E/cluster-home(  867): homescreen.cpp: OnResume(233) >  app resume
05-31 10:33:45.194+0900 E/EFL     (  335): eo<335> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
05-31 10:33:45.224+0900 I/ESD     (  894): esd_main.c: __esd_app_dead_handler(1773) > pid: 21207
05-31 10:33:45.224+0900 W/AUL_AMD (  612): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 21207
05-31 10:33:45.224+0900 W/AUL_AMD (  612): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 21207
05-31 10:33:45.234+0900 E/weather-widget( 1310): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
05-31 10:33:45.254+0900 W/CRASH_MANAGER(21328): worker.c: worker_job(1199) > 1121207636c69149619442
