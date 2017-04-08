S/W Version Information
Model: SM-Z300H
Tizen-Version: 2.4.0.3
Build-Number: Z300HDDU0BPI2
Build-Date: 2016.09.30 15:37:12

Crash Information
Process Name: client
PID: 9462
Date: 2017-04-07 01:12:36+0900
Executable File Path: /opt/usr/apps/org.example.client/bin/client
Signal: 6
      (SIGABRT)
      si_code: -6
      signal sent by tkill (sent by pid 9462, uid 5000)

Register Information
r0   = 0xfffffffc, r1   = 0xb7ed0948
r2   = 0x000003ff, r3   = 0x00000000
r4   = 0xb6eca114, r5   = 0xb66ec470
r6   = 0x40000046, r7   = 0x00000123
r8   = 0x800a130c, r9   = 0xb6deeeac
r10  = 0xb27864bd, fp   = 0xbeef8eac
ip   = 0x00000000, sp   = 0xbeef8e80
lr   = 0xb405b4c0, pc   = 0xb66ec4b4
cpsr = 0x800f0010

Memory Information
MemTotal:   987012 KB
MemFree:    157572 KB
Buffers:     49476 KB
Cached:     325060 KB
VmPeak:     140848 KB
VmSize:     139784 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       35240 KB
VmRSS:       34568 KB
VmData:      51724 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       35780 KB
VmPTE:         108 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 9462 TID = 9462
9462 9463 10001 10002 10011 

Maps Information
af12e000 af92d000 rw-p [stack:10011]
b0f00000 b0f11000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b0f21000 b0f26000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b1328000 b1330000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b1342000 b1b41000 rw-p [stack:10002]
b1b41000 b1b42000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b1b52000 b1b66000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b1b7a000 b1b7b000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b1b8b000 b1b8e000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b1b9f000 b1ba0000 r-xp /usr/lib/libxshmfence.so.1.0.0
b1bb0000 b1bb2000 r-xp /usr/lib/libxcb-present.so.0.0.0
b1bc2000 b1bc4000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b1bd4000 b1be4000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b1bf4000 b1c00000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b1c12000 b2411000 rw-p [stack:10001]
b2742000 b2749000 r-xp /usr/lib/libefl-extension.so.0.1.0
b275c000 b2762000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b2772000 b278e000 r-xp /opt/usr/apps/org.example.client/bin/client
b28e7000 b29ca000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2a01000 b2a29000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2a3b000 b323a000 rw-p [stack:9463]
b323a000 b323c000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b324c000 b3256000 r-xp /lib/libnss_files-2.20-2014.11.so
b3267000 b3270000 r-xp /lib/libnss_nis-2.20-2014.11.so
b3281000 b3292000 r-xp /lib/libnsl-2.20-2014.11.so
b32a5000 b32ab000 r-xp /lib/libnss_compat-2.20-2014.11.so
b32bc000 b32bd000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b32e5000 b32ec000 r-xp /usr/lib/libminizip.so.1.0.0
b32fc000 b3301000 r-xp /usr/lib/libstorage.so.0.1
b3311000 b3370000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b3386000 b339a000 r-xp /usr/lib/libcapi-media-camera.so.0.1.90
b33aa000 b33ee000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b33fe000 b3406000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b3416000 b3446000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b3459000 b3512000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b3526000 b3579000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b358a000 b35a5000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b35b5000 b3676000 r-xp /usr/lib/libprotobuf.so.9.0.1
b3689000 b3699000 r-xp /usr/lib/libefl-assist.so.0.1.0
b36a9000 b36b6000 r-xp /usr/lib/libmdm-common.so.1.0.98
b36c7000 b36ce000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b36de000 b371f000 r-xp /usr/lib/libmdm.so.1.2.12
b372f000 b3737000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b3746000 b3756000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b3777000 b37d7000 r-xp /usr/lib/libasound.so.2.0.0
b37e9000 b37ec000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b37fc000 b37ff000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b380f000 b3814000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b3824000 b3825000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b3835000 b3840000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b3854000 b385b000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b386b000 b3871000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b3881000 b3886000 r-xp /usr/lib/libmmfsession.so.0.0.1
b3896000 b38b1000 r-xp /usr/lib/libmmfsound.so.0.1.0
b38c1000 b38c8000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b38d8000 b38db000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b38ec000 b391a000 r-xp /usr/lib/libidn.so.11.5.44
b392a000 b3940000 r-xp /usr/lib/libnghttp2.so.5.4.0
b3951000 b395b000 r-xp /usr/lib/libcares.so.2.1.0
b396b000 b3975000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.32
b3985000 b3987000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.18
b3997000 b3998000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b39a8000 b39ac000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b39bd000 b39e5000 r-xp /usr/lib/libui-extension.so.0.1.0
b39f6000 b3a1f000 r-xp /usr/lib/libturbojpeg.so
b3a3f000 b3a45000 r-xp /usr/lib/libgif.so.4.1.6
b3a55000 b3a9b000 r-xp /usr/lib/libcurl.so.4.3.0
b3aac000 b3acd000 r-xp /usr/lib/libexif.so.12.3.3
b3ae8000 b3afd000 r-xp /usr/lib/libtts.so
b3b0e000 b3b16000 r-xp /usr/lib/libfeedback.so.0.1.4
b3b26000 b3bec000 r-xp /usr/lib/libdali-core.so.0.0.0
b3c0c000 b3d04000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b3d23000 b3df1000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b3e08000 b3e0a000 r-xp /usr/lib/libboost_system.so.1.51.0
b3e1a000 b3e20000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b3e30000 b3e53000 r-xp /usr/lib/libboost_thread.so.1.51.0
b3e64000 b3e66000 r-xp /usr/lib/libappsvc.so.0.1.0
b3e76000 b3e78000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b3e89000 b3e8e000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b3ea5000 b3ea7000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b3eb7000 b3ebe000 r-xp /usr/lib/libsensord-share.so
b3ece000 b3ee6000 r-xp /usr/lib/libsensor.so.1.1.0
b3ef7000 b3efa000 r-xp /usr/lib/libXv.so.1.0.0
b3f0a000 b3f0f000 r-xp /usr/lib/libutilX.so.1.1.0
b3f1f000 b3f24000 r-xp /usr/lib/libappcore-common.so.1.1
b3f34000 b3f3b000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.11
b3f4e000 b3f52000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b3f63000 b4041000 r-xp /usr/lib/libCOREGL.so.4.0
b4061000 b4064000 r-xp /usr/lib/libuuid.so.1.3.0
b4074000 b408b000 r-xp /usr/lib/libblkid.so.1.1.0
b409c000 b409e000 r-xp /usr/lib/libXau.so.6.0.0
b40ae000 b40f5000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b4107000 b410d000 r-xp /usr/lib/libjson-c.so.2.0.1
b411e000 b4122000 r-xp /usr/lib/libogg.so.0.7.1
b4132000 b4154000 r-xp /usr/lib/libvorbis.so.0.4.3
b4164000 b4248000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b4264000 b4267000 r-xp /usr/lib/libEGL.so.1.4
b4278000 b427e000 r-xp /usr/lib/libxcb-render.so.0.0.0
b428e000 b4290000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b42a0000 b42ad000 r-xp /usr/lib/libGLESv2.so.2.0
b42be000 b4320000 r-xp /usr/lib/libpixman-1.so.0.28.2
b4335000 b434d000 r-xp /usr/lib/libmount.so.1.1.0
b435f000 b4373000 r-xp /usr/lib/libxcb.so.1.1.0
b4383000 b438a000 r-xp /lib/libcrypt-2.20-2014.11.so
b43c2000 b43c4000 r-xp /usr/lib/libiri.so
b43d4000 b43df000 r-xp /usr/lib/libgpg-error.so.0.15.0
b43f0000 b4426000 r-xp /usr/lib/libpulse.so.0.16.2
b4437000 b447a000 r-xp /usr/lib/libsndfile.so.1.0.25
b448f000 b44a4000 r-xp /lib/libexpat.so.1.5.2
b44b6000 b4574000 r-xp /usr/lib/libcairo.so.2.11200.14
b4588000 b4590000 r-xp /usr/lib/libdrm.so.2.4.0
b45a0000 b45a3000 r-xp /usr/lib/libdri2.so.0.0.0
b45b3000 b4601000 r-xp /usr/lib/libssl.so.1.0.0
b4616000 b4622000 r-xp /usr/lib/libeeze.so.1.13.0
b4633000 b463c000 r-xp /usr/lib/libethumb.so.1.13.0
b464c000 b464f000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b465f000 b4816000 r-xp /usr/lib/libcrypto.so.1.0.0
b5601000 b560a000 r-xp /usr/lib/libXi.so.6.1.0
b561a000 b561c000 r-xp /usr/lib/libXgesture.so.7.0.0
b562c000 b5630000 r-xp /usr/lib/libXtst.so.6.1.0
b5640000 b5646000 r-xp /usr/lib/libXrender.so.1.3.0
b5656000 b565c000 r-xp /usr/lib/libXrandr.so.2.2.0
b566c000 b566e000 r-xp /usr/lib/libXinerama.so.1.0.0
b567f000 b5682000 r-xp /usr/lib/libXfixes.so.3.1.0
b5692000 b569d000 r-xp /usr/lib/libXext.so.6.4.0
b56ad000 b56af000 r-xp /usr/lib/libXdamage.so.1.1.0
b56bf000 b56c1000 r-xp /usr/lib/libXcomposite.so.1.0.0
b56d1000 b57b3000 r-xp /usr/lib/libX11.so.6.3.0
b57c7000 b57ce000 r-xp /usr/lib/libXcursor.so.1.0.2
b57de000 b57f6000 r-xp /usr/lib/libudev.so.1.6.0
b57f8000 b57fb000 r-xp /lib/libattr.so.1.1.0
b580b000 b582b000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b582c000 b5831000 r-xp /usr/lib/libffi.so.6.0.2
b5842000 b585a000 r-xp /lib/libz.so.1.2.8
b586a000 b586c000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b587c000 b5951000 r-xp /usr/lib/libxml2.so.2.9.2
b5966000 b5a01000 r-xp /usr/lib/libstdc++.so.6.0.20
b5a1d000 b5a20000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5a30000 b5a49000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5a5a000 b5a6b000 r-xp /lib/libresolv-2.20-2014.11.so
b5a7f000 b5af9000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5b0e000 b5b10000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5b20000 b5b27000 r-xp /usr/lib/libembryo.so.1.13.0
b5b37000 b5b41000 r-xp /usr/lib/libecore_audio.so.1.13.0
b5b52000 b5b6a000 r-xp /usr/lib/libpng12.so.0.50.0
b5b7b000 b5b9e000 r-xp /usr/lib/libjpeg.so.8.0.2
b5bbf000 b5bd3000 r-xp /usr/lib/libector.so.1.13.0
b5be4000 b5bfc000 r-xp /usr/lib/liblua-5.1.so
b5c0d000 b5c64000 r-xp /usr/lib/libfreetype.so.6.11.3
b5c78000 b5ca0000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5cb1000 b5cc4000 r-xp /usr/lib/libfribidi.so.0.3.1
b5cd5000 b5d0f000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5d20000 b5d2e000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5d3e000 b5d46000 r-xp /usr/lib/libtbm.so.1.0.0
b5d56000 b5d63000 r-xp /usr/lib/libeio.so.1.13.0
b5d73000 b5d75000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5d85000 b5d8a000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5d9a000 b5db1000 r-xp /usr/lib/libefreet.so.1.13.0
b5dc3000 b5de3000 r-xp /usr/lib/libeldbus.so.1.13.0
b5df3000 b5e13000 r-xp /usr/lib/libecore_con.so.1.13.0
b5e15000 b5e1b000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5e2b000 b5e3c000 r-xp /usr/lib/libemotion.so.1.13.0
b5e4d000 b5e54000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5e64000 b5e73000 r-xp /usr/lib/libeo.so.1.13.0
b5e84000 b5e96000 r-xp /usr/lib/libecore_input.so.1.13.0
b5ea7000 b5eac000 r-xp /usr/lib/libecore_file.so.1.13.0
b5ebc000 b5ed5000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5ee5000 b5f02000 r-xp /usr/lib/libeet.so.1.13.0
b5f1b000 b5f63000 r-xp /usr/lib/libeina.so.1.13.0
b5f74000 b5f84000 r-xp /usr/lib/libefl.so.1.13.0
b5f95000 b607a000 r-xp /usr/lib/libicuuc.so.51.1
b6097000 b61d7000 r-xp /usr/lib/libicui18n.so.51.1
b61ee000 b6226000 r-xp /usr/lib/libecore_x.so.1.13.0
b6238000 b623b000 r-xp /lib/libcap.so.2.21
b624b000 b6274000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b6285000 b628c000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b629e000 b62d5000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b62e6000 b63d1000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b63e4000 b645d000 r-xp /usr/lib/libsqlite3.so.0.8.6
b646f000 b6474000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b6484000 b648e000 r-xp /usr/lib/libvconf.so.0.2.45
b649e000 b64a0000 r-xp /usr/lib/libvasum.so.0.3.1
b64b0000 b64b2000 r-xp /usr/lib/libttrace.so.1.1
b64c2000 b64c5000 r-xp /usr/lib/libiniparser.so.0
b64d5000 b64fb000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b650b000 b6510000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6521000 b6538000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6549000 b65b4000 r-xp /lib/libm-2.20-2014.11.so
b65c5000 b65cb000 r-xp /lib/librt-2.20-2014.11.so
b65dc000 b65e9000 r-xp /usr/lib/libunwind.so.8.0.1
b661f000 b6743000 r-xp /lib/libc-2.20-2014.11.so
b6758000 b6771000 r-xp /lib/libgcc_s-4.9.so.1
b6781000 b6863000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b6874000 b689e000 r-xp /usr/lib/libdbus-1.so.3.8.12
b68af000 b68eb000 r-xp /usr/lib/libsystemd.so.0.4.0
b68ed000 b6970000 r-xp /usr/lib/libedje.so.1.13.0
b6983000 b69a1000 r-xp /usr/lib/libecore.so.1.13.0
b69c1000 b6b48000 r-xp /usr/lib/libevas.so.1.13.0
b6b7d000 b6b91000 r-xp /lib/libpthread-2.20-2014.11.so
b6ba5000 b6dd9000 r-xp /usr/lib/libelementary.so.1.13.0
b6e08000 b6e0c000 r-xp /usr/lib/libsmack.so.1.0.0
b6e1c000 b6e23000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6e33000 b6e35000 r-xp /usr/lib/libdlog.so.0.0.0
b6e45000 b6e48000 r-xp /usr/lib/libbundle.so.0.1.22
b6e58000 b6e5a000 r-xp /lib/libdl-2.20-2014.11.so
b6e6b000 b6e83000 r-xp /usr/lib/libaul.so.0.1.0
b6e97000 b6e9c000 r-xp /usr/lib/libappcore-efl.so.1.1
b6ead000 b6eba000 r-xp /usr/lib/liblptcp.so
b6ecc000 b6ed0000 r-xp /usr/lib/libsys-assert.so
b6ee1000 b6f01000 r-xp /lib/ld-2.20-2014.11.so
b6f12000 b6f17000 r-xp /usr/bin/launchpad-loader
b7596000 b7f0c000 rw-p [heap]
beed9000 beefa000 rw-p [stack]
End of Maps Information

Callstack Information (PID:9462)
Call Stack Count: 4
 0: recv + 0x44 (0xb66ec4b4) [/lib/libc.so.6] + 0xcd4b4
 1: recv + 0xfc (0xb6eb0d50) [/usr/lib/liblptcp.so] + 0x3d50
 2: _ZN9AppSocket11receiveDataEv + 0x5a (0xb27826e7) [/opt/usr/apps/org.example.client/bin/client] + 0x106e7
 3: (0x3ff) (null)
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
> list_try_to_find_icon_to_show() return
04-07 00:55:34.052+0900 E/INDICATOR(  663): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-07 00:55:34.052+0900 E/INDICATOR(  663): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-07 00:55:34.052+0900 E/INDICATOR(  663): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-07 00:55:34.052+0900 E/INDICATOR(  663): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-07 00:55:34.052+0900 E/INDICATOR(  663): list.c: list_try_to_find_icon_to_remove(378) > (!icon) -> list_try_to_find_icon_to_remove() return
04-07 00:55:34.052+0900 E/INDICATOR(  663): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-07 00:55:34.052+0900 E/INDICATOR(  663): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-07 00:55:34.052+0900 E/INDICATOR(  663): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-07 00:55:34.052+0900 E/INDICATOR(  663): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-07 00:55:34.052+0900 E/INDICATOR(  663): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-07 00:55:34.893+0900 E/PKGMGR_SERVER( 9776): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
04-07 00:55:34.893+0900 E/PKGMGR_SERVER( 9776): pkgmgr-server.c: main(2471) > package manager server terminated.
04-07 00:55:35.133+0900 E/PKGMGR  ( 9933): pkgmgr.c: pkgmgr_client_install(1605) > install pkg start.
04-07 00:55:35.213+0900 E/PKGMGR_SERVER( 9935): pkgmgr-server.c: main(2414) > package manager server start
04-07 00:55:35.263+0900 E/PKGMGR_SERVER( 9935): pkgmgr-server-internal.c: _zone_set_type_and_backend(180) > tep_filepath [/opt/usr/apps/tmp/org.example.client-1.0.0-arm.tpk]
04-07 00:55:35.263+0900 E/PKGMGR_INFO( 9935): pkgmgrinfo_pkginfo.c: pkgmgrinfo_pkginfo_get_unmounted_pkginfo(778) > (exist == 0) pkgid[/opt/usr/apps/tmp/org.example.client-1.0.0-arm.tpk] not found in DB
04-07 00:55:35.273+0900 E/rpm-installer( 9935): librpm.c: __installer_util_delete_dir(171) > opendir(/tmp/coretpk-unzip) failed. [2][No such file or directory]
04-07 00:55:35.283+0900 E/PKGMGR_SERVER( 9935): pm-mdm.c: _pm_check_mdm_policy(75) > [0;31m[_pm_check_mdm_policy(): 75](ret != MDM_RESULT_SUCCESS) can not connect mdm server[0;m
04-07 00:55:35.283+0900 E/PKGMGR  ( 9933): pkgmgr.c: pkgmgr_client_install(1723) > install pkg finish, ret=[99330002]
04-07 00:55:35.403+0900 E/PKGMGR_INSTALLER( 9938): pkgmgr_installer.c: pkgmgr_installer_receive_request(225) > option is [i]
04-07 00:55:35.403+0900 E/rpm-installer( 9938): rpm-appcore-intf.c: main(186) > [/opt/usr/apps/tmp/org.example.client-1.0.0-arm.tpk] is tpk package.
04-07 00:55:35.413+0900 E/rpm-installer( 9938): coretpk-parser.c: _coretpk_parser_is_svc_app(1031) > (ret == 1) NodeSet is empty. (//*[name() = 'manifest']/*[name()='service-application'])
04-07 00:55:35.413+0900 E/rpm-installer( 9938): coretpk-parser.c: __coretpk_parser_get_value(1147) > (result_value == NULL) [install-location] is empty.
04-07 00:55:35.413+0900 E/rpm-installer( 9938): coretpk-parser.c: __coretpk_parser_is_theme(31) > (ret == 1) metadata(watchface) is empty.
04-07 00:55:35.413+0900 E/rpm-installer( 9938): coretpk-parser.c: _coretpk_parser_is_widget(997) > (ret == 1) NodeSet is empty. (//*[name() = 'manifest']/*[name()='widget-application'])
04-07 00:55:35.423+0900 E/rpm-installer( 9938): installer-util.c: _installer_util_get_configuration_value(565) > [signature]=[on]
04-07 00:55:35.473+0900 W/CERT_SVC_VCORE( 9938): DUID.cpp: CheckCertifiedDevice(668) > No device id on distributor certificate
04-07 00:55:35.523+0900 I/Tizen::App( 1248): (1894) > PackageEventHandler - req: 12480002, pkg_type: tpk, pkg_name: org.example.client, key: start, val: install
04-07 00:55:35.523+0900 I/Tizen::App( 1248): (1584) > Package = [org.example.client], Key = [start], Value = [install], install = [1]
04-07 00:55:35.533+0900 I/Tizen::App( 1248): (1894) > PackageEventHandler - req: 12480002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 30
04-07 00:55:35.533+0900 I/Tizen::App( 1248): (119) > InstallationInProgress [30]
04-07 00:55:35.533+0900 I/Tizen::App( 1248): (1584) > Package = [org.example.client], Key = [install_percent], Value = [30], install = [1]
04-07 00:55:35.754+0900 E/rpm-installer( 9938): coretpk-parser.c: __coretpk_parser_check_vip_tag(396) > (ret == 1) metadata(watchface) is empty.
04-07 00:55:35.754+0900 E/rpm-installer( 9938): coretpk-parser.c: __coretpk_parser_get_value(1147) > (result_value == NULL) [ui-gadget] is empty.
04-07 00:55:35.764+0900 E/rpm-installer( 9938): coretpk-parser.c: __coretpk_parser_append_path(335) > (ret == 1) NodeSet is empty. (//@portrait-effectimage)
04-07 00:55:35.764+0900 E/rpm-installer( 9938): coretpk-parser.c: __coretpk_parser_is_theme(31) > (ret == 1) metadata(watchface) is empty.
04-07 00:55:35.764+0900 E/rpm-installer( 9938): coretpk-parser.c: __coretpk_parser_allow_onboot(504) > (ret == 1) metadata is empty.
04-07 00:55:35.764+0900 E/rpm-installer( 9938): coretpk-parser.c: __coretpk_parser_allow_autorestart(566) > (ret == 1) metadata is empty.
04-07 00:55:35.764+0900 W/AUL_AMD (  610): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
04-07 00:55:35.764+0900 W/AUL_AMD (  610): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
04-07 00:55:35.764+0900 E/PKGMGR_PARSER( 9938): pkgmgr_parser.c: pkgmgr_parser_check_manifest_validation(2678) > Manifest is Valid
04-07 00:55:35.774+0900 E/PKGMGR_PARSER( 9938): pkgmgr_parser_signature.c: __ps_check_mdm_policy(979) > (ret != MDM_RESULT_SUCCESS) can not connect mdm server
04-07 00:55:35.804+0900 I/PRIVACY-MANAGER-CLIENT( 9938): SocketClient.cpp: SocketClient(37) > Client created
04-07 00:55:36.024+0900 E/PKGMGR_PARSER( 9938): pkgmgr_parser.c: __check_theme(142) > theme for installation.
04-07 00:55:36.044+0900 E/PKGMGR_CERT( 9938): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(427) > Transaction Begin
04-07 00:55:36.044+0900 E/PKGMGR_CERT( 9938): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 1 109
04-07 00:55:36.044+0900 E/PKGMGR_CERT( 9938): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 2 109
04-07 00:55:36.044+0900 E/PKGMGR_CERT( 9938): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 41 3
04-07 00:55:36.044+0900 E/PKGMGR_CERT( 9938): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 31 4
04-07 00:55:36.044+0900 E/PKGMGR_CERT( 9938): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 32 4
04-07 00:55:36.044+0900 E/PKGMGR_CERT( 9938): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 42 3
04-07 00:55:36.054+0900 E/PKGMGR_CERT( 9938): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(576) > Transaction Commit and End
04-07 00:55:36.064+0900 I/Tizen::App( 1248): (1894) > PackageEventHandler - req: 12480002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 60
04-07 00:55:36.064+0900 I/Tizen::App( 1248): (119) > InstallationInProgress [60]
04-07 00:55:36.064+0900 I/Tizen::App( 1248): (1584) > Package = [org.example.client], Key = [install_percent], Value = [60], install = [1]
04-07 00:55:36.074+0900 E/rpm-installer( 9938): installer-util.c: _installer_util_get_configuration_value(565) > [signature]=[on]
04-07 00:55:36.094+0900 E/rpm-installer( 9938): coretpk-installer.c: __post_install_for_mmc(652) > (handle == NULL) handle is NULL.
04-07 00:55:36.104+0900 I/Tizen::App( 1248): (1894) > PackageEventHandler - req: 12480002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 100
04-07 00:55:36.104+0900 I/Tizen::App( 1248): (119) > InstallationInProgress [100]
04-07 00:55:36.104+0900 I/Tizen::App( 1248): (1584) > Package = [org.example.client], Key = [install_percent], Value = [100], install = [1]
04-07 00:55:37.896+0900 E/PKGMGR_SERVER( 9935): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=0, queue_status=1, drm_status=1] 
04-07 00:55:37.906+0900 I/Tizen::App( 1248): (1894) > PackageEventHandler - req: 12480002, pkg_type: tpk, pkg_name: org.example.client, key: end, val: ok
04-07 00:55:37.906+0900 I/Tizen::App( 1248): (78) > Installation is Completed. [Package = org.example.client]
04-07 00:55:37.906+0900 I/Tizen::App( 1248): (671) > Enter. package(org.example.client), installationResult(0)
04-07 00:55:37.906+0900 E/cluster-home(  869): mainmenu-package-manager.cpp: OnClientListenCb(571) >  #Step 1
04-07 00:55:37.906+0900 E/cluster-home(  869): mainmenu-package-manager.cpp: OnClientListenCb(575) >  #Step 2
04-07 00:55:37.906+0900 E/cluster-home(  869): mainmenu-package-manager.cpp: _GetAppIds(350) >  BEGIN
04-07 00:55:37.916+0900 I/Tizen::App( 1248): (1360) > package(org.example.client), version(1.0.0), type(tpk), displayName(client), uninstallable(1), downloaded(1), updated(0), preloaded(0)movable(1), externalStorage(0), mainApp(org.example.client), storeClient(), appRootPath(/opt/usr/apps/org.example.client)
04-07 00:55:37.936+0900 I/Tizen::App( 1248): (483) > pkgmgrinfo_appinfo_get_appid(): app = [org.example.client]
04-07 00:55:37.946+0900 I/Tizen::App( 1248): (416) > appName = [client]
04-07 00:55:37.946+0900 I/Tizen::App( 1248): (509) > exe = [/opt/usr/apps/org.example.client/bin/client], displayName = [client], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
04-07 00:55:37.946+0900 E/PKGMGR_INFO( 1248): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(887) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
04-07 00:55:37.946+0900 I/Tizen::App( 1248): (683) > Application count(1) in this package
04-07 00:55:37.946+0900 I/Tizen::App( 1248): (840) > Enter.
04-07 00:55:37.946+0900 W/ISF_PANEL_EFL(  774): isf_panel_efl.cpp: _package_manager_event_cb(1513) > _isf_insert_ime_info_by_pkgid returned 0.
04-07 00:55:37.956+0900 I/Tizen::App( 1248): (703) > Exit.
04-07 00:55:37.956+0900 I/Tizen::App( 1248): (1584) > Package = [org.example.client], Key = [end], Value = [ok], install = [1]
04-07 00:55:37.956+0900 I/Tizen::App( 1248): (416) > appName = [client]
04-07 00:55:37.956+0900 I/Tizen::App( 1248): (509) > exe = [/opt/usr/apps/org.example.client/bin/client], displayName = [client], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
04-07 00:55:37.956+0900 I/Tizen::App( 1248): (2343) > info file is not existed. [/opt/usr/apps/org.exampl/info/org.example.client.info]
04-07 00:55:37.956+0900 I/Tizen::App( 1248): (131) > Enter
04-07 00:55:37.956+0900 E/cluster-home(  869): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(253) >  ##### [org.example.client]
04-07 00:55:37.966+0900 E/cluster-home(  869): mainmenu-package-manager.cpp: _GetAppIds(375) >  ##### [org.example.client]
04-07 00:55:37.966+0900 E/cluster-home(  869): mainmenu-package-manager.cpp: _GetAppIds(379) >  END
04-07 00:55:37.966+0900 E/cluster-home(  869): mainmenu-package-manager.cpp: _DoPkgJob(458) >  #Step 3 size[1]
04-07 00:55:37.966+0900 E/cluster-home(  869): mainmenu-package-manager.cpp: _DoPkgJob(462) >  appId[org.example.client]
04-07 00:55:37.966+0900 I/Tizen::App( 1248): (137) > org.example.client does not have launch condition
04-07 00:55:37.966+0900 I/Tizen::App( 1248): (883) > Exit.
04-07 00:55:37.976+0900 E/cluster-home(  869): mainmenu-package-manager.cpp: _GetAppInfo(990) >  Name[client] enable[1] system[0]
04-07 00:55:37.976+0900 E/HOME_APPS(  869): mainmenu-package-manager.cpp: _DoPkgJob(484) >  appId[org.example.client] mdm is not enabled
04-07 00:55:37.976+0900 E/cluster-home(  869): mainmenu-package-manager.cpp: GetAppInfo(630) >  Find a App Info Name[client] enable[1] system[0]
04-07 00:55:37.976+0900 W/HOME_APPS(  869): mainmenu-box-impl.cpp: UpdateBoxData(1326) >  update box data!!!!! old icon path[/opt/usr/apps/org.example.client/shared/res/client.png], New icon path[/opt/usr/apps/org.example.client/shared/res/client.png]!!!!!
04-07 00:55:37.976+0900 E/PKGMGR_SERVER( 9935): pkgmgr-server.c: sighandler(417) > child NORMAL exit [9938]
04-07 00:55:37.996+0900 E/util-view(  869): util-text-image-provider.cpp: GetPixelsFromText(240) >  DEFAULT='font=SamsungOneUI:style=Regular style=shadow,bottom shadow_color=# font_size=28 align=center valign=top color=#FFFFFF color_class=ATO001 text_class=ATO001 ellipsis=1 wrap=mixed linegap=-3'
04-07 00:55:38.016+0900 W/HOME_APPS(  869): mainmenu-box-impl.cpp: _OnImageLoadFinishedHandler(2152) >  finished path[/opt/usr/apps/org.example.client/shared/res/client.png], Loading state:[1]
04-07 00:55:39.898+0900 E/PKGMGR_SERVER( 9935): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
04-07 00:55:39.898+0900 E/PKGMGR_SERVER( 9935): pkgmgr-server.c: main(2471) > package manager server terminated.
04-07 00:55:41.719+0900 E/INDICATOR(  663): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-07 00:55:41.719+0900 E/INDICATOR(  663): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-07 00:55:41.719+0900 E/INDICATOR(  663): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-07 00:55:41.719+0900 E/INDICATOR(  663): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-07 00:55:41.719+0900 E/INDICATOR(  663): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-07 00:55:41.750+0900 E/INDICATOR(  663): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-07 00:55:41.750+0900 E/INDICATOR(  663): list.c: list_try_to_find_icon_to_remove(378) > (!icon) -> list_try_to_find_icon_to_remove() return
04-07 00:55:41.750+0900 E/INDICATOR(  663): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-07 00:55:41.750+0900 E/INDICATOR(  663): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-07 00:55:41.750+0900 E/INDICATOR(  663): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-07 00:55:41.760+0900 E/INDICATOR(  663): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-07 00:55:41.760+0900 E/INDICATOR(  663): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-07 00:55:42.340+0900 W/AUL     ( 9994): launch.c: app_request_to_launchpad(396) > request cmd(0) to(org.example.client)
04-07 00:55:42.340+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 0
04-07 00:55:42.350+0900 I/AUL     (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/launch_app, ret : 0
04-07 00:55:42.350+0900 I/AUL     (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /bin/bash, ret : 0
04-07 00:55:42.350+0900 E/AUL_AMD (  610): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
04-07 00:55:42.350+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(2508) > caller pid : 9994
04-07 00:55:42.350+0900 E/AUL_AMD (  610): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
04-07 00:55:42.360+0900 E/RESOURCED(  665): block.c: block_prelaunch_state(134) > insert data org.example.client, table num : 3
04-07 00:55:42.360+0900 E/RESOURCED(  665): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
04-07 00:55:42.370+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(3052) > pad pid(-5)
04-07 00:55:42.370+0900 W/AUL_PAD ( 1536): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
04-07 00:55:42.370+0900 W/AUL_PAD ( 1536): launchpad.c: __send_result_to_caller(267) > Check app launching
04-07 00:55:42.380+0900 I/abc     ( 9462): abc
04-07 00:55:42.380+0900 I/CAPI_APPFW_APPLICATION( 9462): app_main.c: ui_app_main(789) > app_efl_main
04-07 00:55:42.380+0900 I/CAPI_APPFW_APPLICATION( 9462): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
04-07 00:55:42.410+0900 E/TBM     ( 9462): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
04-07 00:55:42.470+0900 W/AUL     (  610): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 9462, appid: org.example.client
04-07 00:55:42.470+0900 E/AUL     (  610): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
04-07 00:55:42.480+0900 W/AUL     ( 9994): launch.c: app_request_to_launchpad(425) > request cmd(0) result(9462)
04-07 00:55:42.680+0900 D/basicui ( 9462): successed to load edc file
04-07 00:55:42.720+0900 E/EFL     (  434): eo<434> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-07 00:55:42.720+0900 E/EFL     (  434): eo<434> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-07 00:55:42.730+0900 I/Tizen::System( 1248): (259) > Active app [org.exampl], current [com.samsun] 
04-07 00:55:42.730+0900 I/Tizen::Io( 1248): (729) > Entry not found
04-07 00:55:42.740+0900 I/Tizen::System( 1248): (157) > change brightness system value.
04-07 00:55:42.750+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
04-07 00:55:42.770+0900 I/MY_LOG  ( 9462): change
04-07 00:55:42.821+0900 I/APP_CORE( 9462): appcore-efl.c: __do_app(514) > [APP 9462] Event: RESET State: CREATED
04-07 00:55:42.821+0900 I/CAPI_APPFW_APPLICATION( 9462): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
04-07 00:55:42.831+0900 E/EFL     ( 9462): edje<9462> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-07 00:55:42.831+0900 E/EFL     ( 9462): By the power of Grayskull, your previous Embryo stack is now broken!
04-07 00:55:42.831+0900 E/EFL     ( 9462): edje<9462> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-07 00:55:42.831+0900 E/EFL     ( 9462): By the power of Grayskull, your previous Embryo stack is now broken!
04-07 00:55:42.831+0900 E/EFL     ( 9462): edje<9462> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-07 00:55:42.831+0900 E/EFL     ( 9462): By the power of Grayskull, your previous Embryo stack is now broken!
04-07 00:55:42.841+0900 W/APP_CORE( 9462): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:6400002
04-07 00:55:42.841+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 35
04-07 00:55:42.961+0900 I/APP_CORE(  869): appcore-efl.c: __do_app(514) > [APP 869] Event: PAUSE State: RUNNING
04-07 00:55:42.961+0900 I/CAPI_APPFW_APPLICATION(  869): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
04-07 00:55:42.961+0900 E/cluster-home(  869): homescreen.cpp: OnPause(260) >  app pause
04-07 00:55:42.961+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(869) status(4)
04-07 00:55:42.961+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(869)
04-07 00:55:42.961+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 869, appid: com.samsung.homescreen, status: bg
04-07 00:55:42.961+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(9462) status(3)
04-07 00:55:42.971+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-07 00:55:42.971+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
04-07 00:55:42.971+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.client(9462)
04-07 00:55:42.971+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 9462, appid: org.example.client, status: fg
04-07 00:55:42.971+0900 I/CAPI_WIDGET_APPLICATION( 1436): widget_app.c: __provider_pause_cb(304) > widget obj was paused
04-07 00:55:42.971+0900 I/CAPI_WIDGET_APPLICATION( 1436): widget_app.c: __check_status_for_cgroup(152) > enter background group
04-07 00:55:42.971+0900 W/AUL     ( 1436): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1436, appid: live-com.samsung.browser, status: bg
04-07 00:55:42.971+0900 I/APP_CORE( 9462): appcore-efl.c: __do_app(514) > [APP 9462] Event: RESUME State: CREATED
04-07 00:55:42.991+0900 I/APP_CORE( 9462): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
04-07 00:55:42.991+0900 I/APP_CORE( 9462): appcore-efl.c: __do_app(625) > [APP 9462] Initial Launching, call the resume_cb
04-07 00:55:42.991+0900 I/CAPI_APPFW_APPLICATION( 9462): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-07 00:55:43.321+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(9462) status(0)
04-07 00:55:43.521+0900 I/Tizen::App( 1248): (499) > LaunchedApp(org.example.client)
04-07 00:55:43.521+0900 I/Tizen::App( 1248): (733) > Finished invoking application event listener for org.example.client, 9462.
04-07 00:55:43.521+0900 E/RESOURCED(  665): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.481
04-07 00:55:44.282+0900 I/UXT     (10007): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
04-07 00:55:47.976+0900 I/APP_CORE(  869): appcore-efl.c: __do_app(514) > [APP 869] Event: MEM_FLUSH State: PAUSED
04-07 00:55:56.414+0900 E/EFL     ( 9462): ecore_x<9462> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=68913519
04-07 00:55:56.414+0900 I/MY_LOG  ( 9462): Button pressed
04-07 00:55:56.514+0900 E/EFL     ( 9462): ecore_x<9462> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=68913619
04-07 00:55:56.514+0900 E/VCONF   ( 9462): vconf.c: _vconf_check_retry_err(1368) > db/ise/keysound : check retry err (-21/13).
04-07 00:55:56.514+0900 E/VCONF   ( 9462): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(db/ise/keysound) step(-21) failed(13 / Permission denied) retry(0) 
04-07 00:55:56.514+0900 E/VCONF   ( 9462): vconf.c: _vconf_get_key(2407) > _vconf_get_key(db/ise/keysound) step(-21) failed(13 / Permission denied)
04-07 00:55:56.514+0900 E/VCONF   ( 9462): vconf.c: vconf_get_bool(2729) > vconf_get_bool(9462) : db/ise/keysound error
04-07 00:55:56.514+0900 E/VCONF   ( 9462): vconf-kdb.c: _vconf_kdb_add_notify(318) > _vconf_kdb_add_notify : add noti(Permission denied)
04-07 00:55:56.514+0900 E/VCONF   ( 9462): vconf.c: vconf_notify_key_changed(3168) > vconf_notify_key_changed : key(db/ise/keysound) add notify fail
04-07 00:55:56.574+0900 I/MY_LOG  ( 9462): Button unpressed
04-07 00:55:56.664+0900 D/basicui ( 9462): successed to load edc file
04-07 00:55:56.684+0900 I/MY_LOG  ( 9462): change
04-07 00:55:58.776+0900 E/EFL     ( 9462): ecore_x<9462> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=68915881
04-07 00:55:58.866+0900 E/EFL     ( 9462): ecore_x<9462> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=68915969
04-07 00:56:00.147+0900 I/INDICATOR(  663): clock.c: indicator_clock_changed_cb(195) > ""
04-07 00:56:00.157+0900 E/UXT     (  663): uxt_util.c: uxt_util_get_date_time_text_by_locale(389) > text : 오전 12:56
04-07 00:56:00.157+0900 I/INDICATOR(  663): clock.c: getTimeFormatted(176) > "time format : 오전 12:56"
04-07 00:56:00.157+0900 I/INDICATOR(  663): clock.c: indicator_clock_changed_cb(244) > "time format : 오전 12:56"
04-07 00:56:00.157+0900 W/INDICATOR(  663): clock.c: indicator_clock_changed_cb(272) > 
04-07 00:56:00.157+0900 I/INDICATOR(  663): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2146593782 Time: <font_size=31> </font_size> <font_size=31> 오전 12:56</font_size></font>"
04-07 00:57:00.196+0900 I/INDICATOR(  663): clock.c: indicator_clock_changed_cb(195) > ""
04-07 00:57:00.206+0900 E/UXT     (  663): uxt_util.c: uxt_util_get_date_time_text_by_locale(389) > text : 오전 12:57
04-07 00:57:00.206+0900 I/INDICATOR(  663): clock.c: getTimeFormatted(176) > "time format : 오전 12:57"
04-07 00:57:00.206+0900 I/INDICATOR(  663): clock.c: indicator_clock_changed_cb(244) > "time format : 오전 12:57"
04-07 00:57:00.206+0900 W/INDICATOR(  663): clock.c: indicator_clock_changed_cb(272) > 
04-07 00:57:00.206+0900 I/INDICATOR(  663): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2146591730 Time: <font_size=31> </font_size> <font_size=31> 오전 12:57</font_size></font>"
04-07 00:57:06.202+0900 E/INDICATOR(  663): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-07 00:57:06.202+0900 E/INDICATOR(  663): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-07 00:57:06.202+0900 E/INDICATOR(  663): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-07 00:57:06.202+0900 E/INDICATOR(  663): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-07 00:57:06.202+0900 E/INDICATOR(  663): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-07 00:57:06.202+0900 E/INDICATOR(  663): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-07 00:57:06.202+0900 E/INDICATOR(  663): list.c: list_try_to_find_icon_to_remove(378) > (!icon) -> list_try_to_find_icon_to_remove() return
04-07 00:57:06.202+0900 E/INDICATOR(  663): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-07 00:57:06.202+0900 E/INDICATOR(  663): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-07 00:57:06.202+0900 E/INDICATOR(  663): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-07 00:57:06.212+0900 E/INDICATOR(  663): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-07 00:57:06.212+0900 E/INDICATOR(  663): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-07 00:58:00.255+0900 I/INDICATOR(  663): clock.c: indicator_clock_changed_cb(195) > ""
04-07 00:58:00.255+0900 E/UXT     (  663): uxt_util.c: uxt_util_get_date_time_text_by_locale(389) > text : 오전 12:58
04-07 00:58:00.255+0900 I/INDICATOR(  663): clock.c: getTimeFormatted(176) > "time format : 오전 12:58"
04-07 00:58:00.255+0900 I/INDICATOR(  663): clock.c: indicator_clock_changed_cb(244) > "time format : 오전 12:58"
04-07 00:58:00.255+0900 W/INDICATOR(  663): clock.c: indicator_clock_changed_cb(272) > 
04-07 00:58:00.255+0900 I/INDICATOR(  663): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2146573252 Time: <font_size=31> </font_size> <font_size=31> 오전 12:58</font_size></font>"
04-07 00:59:00.293+0900 I/INDICATOR(  663): clock.c: indicator_clock_changed_cb(195) > ""
04-07 00:59:00.293+0900 E/UXT     (  663): uxt_util.c: uxt_util_get_date_time_text_by_locale(389) > text : 오전 12:59
04-07 00:59:00.293+0900 I/INDICATOR(  663): clock.c: getTimeFormatted(176) > "time format : 오전 12:59"
04-07 00:59:00.293+0900 I/INDICATOR(  663): clock.c: indicator_clock_changed_cb(244) > "time format : 오전 12:59"
04-07 00:59:00.293+0900 W/INDICATOR(  663): clock.c: indicator_clock_changed_cb(272) > 
04-07 00:59:00.293+0900 I/INDICATOR(  663): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2146571200 Time: <font_size=31> </font_size> <font_size=31> 오전 12:59</font_size></font>"
04-07 01:00:00.352+0900 I/INDICATOR(  663): clock.c: indicator_clock_changed_cb(195) > ""
04-07 01:00:00.352+0900 E/UXT     (  663): uxt_util.c: uxt_util_get_date_time_text_by_locale(389) > text : 오전 1:00
04-07 01:00:00.352+0900 I/INDICATOR(  663): clock.c: getTimeFormatted(176) > "time format : 오전 1:00"
04-07 01:00:00.352+0900 I/INDICATOR(  663): clock.c: indicator_clock_changed_cb(244) > "time format : 오전 1:00"
04-07 01:00:00.352+0900 W/INDICATOR(  663): clock.c: indicator_clock_changed_cb(272) > 
04-07 01:00:00.352+0900 E/INDICATOR(  663): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-07 01:00:00.352+0900 E/INDICATOR(  663): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-07 01:00:00.352+0900 E/INDICATOR(  663): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-07 01:00:00.352+0900 E/INDICATOR(  663): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-07 01:00:00.352+0900 E/INDICATOR(  663): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-07 01:00:00.352+0900 I/INDICATOR(  663): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2146569148 Time: <font_size=31> </font_size> <font_size=31> 오전 1:00</font_size></font>"
04-07 01:01:00.420+0900 I/INDICATOR(  663): clock.c: indicator_clock_changed_cb(195) > ""
04-07 01:01:00.420+0900 E/UXT     (  663): uxt_util.c: uxt_util_get_date_time_text_by_locale(389) > text : 오전 1:01
04-07 01:01:00.420+0900 I/INDICATOR(  663): clock.c: getTimeFormatted(176) > "time format : 오전 1:01"
04-07 01:01:00.420+0900 I/INDICATOR(  663): clock.c: indicator_clock_changed_cb(244) > "time format : 오전 1:01"
04-07 01:01:00.420+0900 W/INDICATOR(  663): clock.c: indicator_clock_changed_cb(272) > 
04-07 01:01:00.420+0900 I/INDICATOR(  663): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2146559407 Time: <font_size=31> </font_size> <font_size=31> 오전 1:01</font_size></font>"
04-07 01:01:27.337+0900 E/INDICATOR(  663): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-07 01:01:27.337+0900 E/INDICATOR(  663): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-07 01:01:27.337+0900 E/INDICATOR(  663): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-07 01:01:27.337+0900 E/INDICATOR(  663): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-07 01:01:27.337+0900 E/INDICATOR(  663): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-07 01:01:27.337+0900 E/INDICATOR(  663): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-07 01:01:27.337+0900 E/INDICATOR(  663): list.c: list_try_to_find_icon_to_remove(378) > (!icon) -> list_try_to_find_icon_to_remove() return
04-07 01:01:27.337+0900 E/INDICATOR(  663): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-07 01:01:27.337+0900 E/INDICATOR(  663): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-07 01:01:27.337+0900 E/INDICATOR(  663): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-07 01:01:27.337+0900 E/INDICATOR(  663): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-07 01:01:27.337+0900 E/INDICATOR(  663): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-07 01:01:54.643+0900 E/EFL     ( 9462): ecore_x<9462> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=69271745
04-07 01:01:54.733+0900 E/EFL     ( 9462): ecore_x<9462> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=69271845
04-07 01:02:00.419+0900 I/INDICATOR(  663): clock.c: indicator_clock_changed_cb(195) > ""
04-07 01:02:00.419+0900 E/UXT     (  663): uxt_util.c: uxt_util_get_date_time_text_by_locale(389) > text : 오전 1:02
04-07 01:02:00.419+0900 I/INDICATOR(  663): clock.c: getTimeFormatted(176) > "time format : 오전 1:02"
04-07 01:02:00.419+0900 I/INDICATOR(  663): clock.c: indicator_clock_changed_cb(244) > "time format : 오전 1:02"
04-07 01:02:00.419+0900 W/INDICATOR(  663): clock.c: indicator_clock_changed_cb(272) > 
04-07 01:02:00.419+0900 I/INDICATOR(  663): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2146526569 Time: <font_size=31> </font_size> <font_size=31> 오전 1:02</font_size></font>"
04-07 01:03:00.478+0900 I/INDICATOR(  663): clock.c: indicator_clock_changed_cb(195) > ""
04-07 01:03:00.478+0900 E/UXT     (  663): uxt_util.c: uxt_util_get_date_time_text_by_locale(389) > text : 오전 1:03
04-07 01:03:00.478+0900 I/INDICATOR(  663): clock.c: getTimeFormatted(176) > "time format : 오전 1:03"
04-07 01:03:00.478+0900 I/INDICATOR(  663): clock.c: indicator_clock_changed_cb(244) > "time format : 오전 1:03"
04-07 01:03:00.478+0900 W/INDICATOR(  663): clock.c: indicator_clock_changed_cb(272) > 
04-07 01:03:00.478+0900 I/INDICATOR(  663): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2146524517 Time: <font_size=31> </font_size> <font_size=31> 오전 1:03</font_size></font>"
04-07 01:03:30.217+0900 E/INDICATOR(  663): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-07 01:03:30.217+0900 E/INDICATOR(  663): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-07 01:03:30.217+0900 E/INDICATOR(  663): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-07 01:03:30.217+0900 E/INDICATOR(  663): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-07 01:03:30.217+0900 E/INDICATOR(  663): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-07 01:03:30.217+0900 E/INDICATOR(  663): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-07 01:03:30.217+0900 E/INDICATOR(  663): list.c: list_try_to_find_icon_to_remove(378) > (!icon) -> list_try_to_find_icon_to_remove() return
04-07 01:03:30.217+0900 E/INDICATOR(  663): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-07 01:03:30.217+0900 E/INDICATOR(  663): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-07 01:03:30.217+0900 E/INDICATOR(  663): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-07 01:03:30.217+0900 E/INDICATOR(  663): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-07 01:03:30.217+0900 E/INDICATOR(  663): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-07 01:04:00.506+0900 I/INDICATOR(  663): clock.c: indicator_clock_changed_cb(195) > ""
04-07 01:04:00.506+0900 E/UXT     (  663): uxt_util.c: uxt_util_get_date_time_text_by_locale(389) > text : 오전 1:04
04-07 01:04:00.506+0900 I/INDICATOR(  663): clock.c: getTimeFormatted(176) > "time format : 오전 1:04"
04-07 01:04:00.506+0900 I/INDICATOR(  663): clock.c: indicator_clock_changed_cb(244) > "time format : 오전 1:04"
04-07 01:04:00.506+0900 W/INDICATOR(  663): clock.c: indicator_clock_changed_cb(272) > 
04-07 01:04:00.506+0900 I/INDICATOR(  663): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2146500919 Time: <font_size=31> </font_size> <font_size=31> 오전 1:04</font_size></font>"
04-07 01:05:00.555+0900 I/INDICATOR(  663): clock.c: indicator_clock_changed_cb(195) > ""
04-07 01:05:00.555+0900 E/UXT     (  663): uxt_util.c: uxt_util_get_date_time_text_by_locale(389) > text : 오전 1:05
04-07 01:05:00.555+0900 I/INDICATOR(  663): clock.c: getTimeFormatted(176) > "time format : 오전 1:05"
04-07 01:05:00.555+0900 I/INDICATOR(  663): clock.c: indicator_clock_changed_cb(244) > "time format : 오전 1:05"
04-07 01:05:00.555+0900 W/INDICATOR(  663): clock.c: indicator_clock_changed_cb(272) > 
04-07 01:05:00.555+0900 I/INDICATOR(  663): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2146498867 Time: <font_size=31> </font_size> <font_size=31> 오전 1:05</font_size></font>"
04-07 01:06:00.613+0900 I/INDICATOR(  663): clock.c: indicator_clock_changed_cb(195) > ""
04-07 01:06:00.613+0900 E/UXT     (  663): uxt_util.c: uxt_util_get_date_time_text_by_locale(389) > text : 오전 1:06
04-07 01:06:00.613+0900 I/INDICATOR(  663): clock.c: getTimeFormatted(176) > "time format : 오전 1:06"
04-07 01:06:00.613+0900 I/INDICATOR(  663): clock.c: indicator_clock_changed_cb(244) > "time format : 오전 1:06"
04-07 01:06:00.613+0900 W/INDICATOR(  663): clock.c: indicator_clock_changed_cb(272) > 
04-07 01:06:00.613+0900 I/INDICATOR(  663): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2146496815 Time: <font_size=31> </font_size> <font_size=31> 오전 1:06</font_size></font>"
04-07 01:06:29.902+0900 E/EFL     ( 9462): ecore_x<9462> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=69547016
04-07 01:06:30.032+0900 E/EFL     ( 9462): ecore_x<9462> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=69547138
04-07 01:07:00.672+0900 I/INDICATOR(  663): clock.c: indicator_clock_changed_cb(195) > ""
04-07 01:07:00.672+0900 E/UXT     (  663): uxt_util.c: uxt_util_get_date_time_text_by_locale(389) > text : 오전 1:07
04-07 01:07:00.672+0900 I/INDICATOR(  663): clock.c: getTimeFormatted(176) > "time format : 오전 1:07"
04-07 01:07:00.672+0900 I/INDICATOR(  663): clock.c: indicator_clock_changed_cb(244) > "time format : 오전 1:07"
04-07 01:07:00.672+0900 W/INDICATOR(  663): clock.c: indicator_clock_changed_cb(272) > 
04-07 01:07:00.672+0900 I/INDICATOR(  663): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2146494763 Time: <font_size=31> </font_size> <font_size=31> 오전 1:07</font_size></font>"
04-07 01:07:09.601+0900 E/EFL     ( 9462): ecore_x<9462> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=69586712
04-07 01:07:09.741+0900 E/EFL     ( 9462): ecore_x<9462> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=69586844
04-07 01:08:00.730+0900 I/INDICATOR(  663): clock.c: indicator_clock_changed_cb(195) > ""
04-07 01:08:00.730+0900 E/UXT     (  663): uxt_util.c: uxt_util_get_date_time_text_by_locale(389) > text : 오전 1:08
04-07 01:08:00.730+0900 I/INDICATOR(  663): clock.c: getTimeFormatted(176) > "time format : 오전 1:08"
04-07 01:08:00.730+0900 I/INDICATOR(  663): clock.c: indicator_clock_changed_cb(244) > "time format : 오전 1:08"
04-07 01:08:00.730+0900 W/INDICATOR(  663): clock.c: indicator_clock_changed_cb(272) > 
04-07 01:08:00.730+0900 I/INDICATOR(  663): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2146492711 Time: <font_size=31> </font_size> <font_size=31> 오전 1:08</font_size></font>"
04-07 01:09:00.779+0900 I/INDICATOR(  663): clock.c: indicator_clock_changed_cb(195) > ""
04-07 01:09:00.779+0900 E/UXT     (  663): uxt_util.c: uxt_util_get_date_time_text_by_locale(389) > text : 오전 1:09
04-07 01:09:00.779+0900 I/INDICATOR(  663): clock.c: getTimeFormatted(176) > "time format : 오전 1:09"
04-07 01:09:00.779+0900 I/INDICATOR(  663): clock.c: indicator_clock_changed_cb(244) > "time format : 오전 1:09"
04-07 01:09:00.779+0900 W/INDICATOR(  663): clock.c: indicator_clock_changed_cb(272) > 
04-07 01:09:00.779+0900 I/INDICATOR(  663): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2146490659 Time: <font_size=31> </font_size> <font_size=31> 오전 1:09</font_size></font>"
04-07 01:10:00.838+0900 I/INDICATOR(  663): clock.c: indicator_clock_changed_cb(195) > ""
04-07 01:10:00.838+0900 E/UXT     (  663): uxt_util.c: uxt_util_get_date_time_text_by_locale(389) > text : 오전 1:10
04-07 01:10:00.838+0900 I/INDICATOR(  663): clock.c: getTimeFormatted(176) > "time format : 오전 1:10"
04-07 01:10:00.838+0900 I/INDICATOR(  663): clock.c: indicator_clock_changed_cb(244) > "time format : 오전 1:10"
04-07 01:10:00.838+0900 W/INDICATOR(  663): clock.c: indicator_clock_changed_cb(272) > 
04-07 01:10:00.838+0900 I/INDICATOR(  663): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2146488607 Time: <font_size=31> </font_size> <font_size=31> 오전 1:10</font_size></font>"
04-07 01:10:23.179+0900 E/EFL     ( 9462): ecore_x<9462> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=69780290
04-07 01:10:23.250+0900 E/EFL     ( 9462): ecore_x<9462> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=69780367
04-07 01:11:00.896+0900 I/INDICATOR(  663): clock.c: indicator_clock_changed_cb(195) > ""
04-07 01:11:00.896+0900 E/UXT     (  663): uxt_util.c: uxt_util_get_date_time_text_by_locale(389) > text : 오전 1:11
04-07 01:11:00.896+0900 I/INDICATOR(  663): clock.c: getTimeFormatted(176) > "time format : 오전 1:11"
04-07 01:11:00.896+0900 I/INDICATOR(  663): clock.c: indicator_clock_changed_cb(244) > "time format : 오전 1:11"
04-07 01:11:00.896+0900 W/INDICATOR(  663): clock.c: indicator_clock_changed_cb(272) > 
04-07 01:11:00.896+0900 I/INDICATOR(  663): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2146486555 Time: <font_size=31> </font_size> <font_size=31> 오전 1:11</font_size></font>"
04-07 01:11:46.150+0900 E/EFL     ( 9462): ecore_x<9462> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=69863253
04-07 01:11:46.230+0900 E/EFL     ( 9462): ecore_x<9462> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=69863341
04-07 01:12:00.905+0900 I/INDICATOR(  663): clock.c: indicator_clock_changed_cb(195) > ""
04-07 01:12:00.905+0900 E/UXT     (  663): uxt_util.c: uxt_util_get_date_time_text_by_locale(389) > text : 오전 1:12
04-07 01:12:00.905+0900 I/INDICATOR(  663): clock.c: getTimeFormatted(176) > "time format : 오전 1:12"
04-07 01:12:00.905+0900 I/INDICATOR(  663): clock.c: indicator_clock_changed_cb(244) > "time format : 오전 1:12"
04-07 01:12:00.905+0900 W/INDICATOR(  663): clock.c: indicator_clock_changed_cb(272) > 
04-07 01:12:00.905+0900 I/INDICATOR(  663): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2146471175 Time: <font_size=31> </font_size> <font_size=31> 오전 1:12</font_size></font>"
04-07 01:12:25.038+0900 E/EFL     ( 9462): ecore_x<9462> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=69902144
04-07 01:12:25.148+0900 E/EFL     ( 9462): ecore_x<9462> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=69902254
04-07 01:12:36.159+0900 E/RESOURCED(  665): proc-monitor.c: proc_dbus_watchdog_handler(711) > Receive watchdog signal to pid: 9462(client)
04-07 01:12:36.159+0900 E/RESOURCED(  665): proc-monitor.c: proc_dbus_watchdog_handler(727) > just kill watchdog process when debug enabled pid: 9462(client)
04-07 01:12:36.159+0900 E/RESOURCED(  665): file-helper.c: fwrite_str(49) > Fail to open file /sys/fs/cgroup/net_cls/(null)/cgroup.procs
04-07 01:12:36.159+0900 E/RESOURCED(  665): file-helper.c: fwrite_str(49) > errno -2, errmsg No such file or directory
04-07 01:12:36.159+0900 E/RESOURCED(  665): cgroup.c: place_pid_to_cgroup_by_fullpath(76) > Failed place all pid to cgroup /sys/fs/cgroup/net_cls/(null), error No such file or directory
04-07 01:12:36.299+0900 E/EFL     (  434): eo<434> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-07 01:12:36.309+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(869) status(3)
04-07 01:12:36.309+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-07 01:12:36.309+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
04-07 01:12:36.309+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(869)
04-07 01:12:36.309+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 869, appid: com.samsung.homescreen, status: fg
04-07 01:12:36.329+0900 I/AUL_PAD ( 1536): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 9462 pgid = 9462
04-07 01:12:36.329+0900 I/AUL_PAD ( 1536): sigchild.h: __sigchild_action(143) > dead_pid(9462)
04-07 01:12:36.349+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(869) status(0)
04-07 01:12:36.369+0900 E/EFL     (  434): eo<434> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-07 01:12:36.379+0900 I/APP_CORE(  869): appcore-efl.c: __do_app(514) > [APP 869] Event: RESUME State: PAUSED
04-07 01:12:36.379+0900 I/CAPI_APPFW_APPLICATION(  869): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-07 01:12:36.379+0900 E/cluster-home(  869): homescreen.cpp: OnResume(233) >  app resume
04-07 01:12:36.409+0900 I/Tizen::System( 1248): (259) > Active app [com.samsun], current [org.exampl] 
04-07 01:12:36.409+0900 I/Tizen::Io( 1248): (729) > Entry not found
04-07 01:12:36.419+0900 I/CAPI_WIDGET_APPLICATION( 1436): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
04-07 01:12:36.419+0900 I/CAPI_WIDGET_APPLICATION( 1436): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
04-07 01:12:36.419+0900 W/AUL     ( 1436): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1436, appid: live-com.samsung.browser, status: fg
04-07 01:12:36.429+0900 E/EFL     (  663): <663> lib/ecore_ipc/ecore_ipc.c:804 ecore_ipc_client_send() safety check failed: !ecore_con_client_connected_get(cl->client) is true
04-07 01:12:36.439+0900 I/AUL_PAD ( 1536): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
04-07 01:12:36.439+0900 I/AUL_PAD ( 1536): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
04-07 01:12:36.439+0900 E/AUL_PAD ( 1536): launchpad.c: main(698) > error reading sigchld info
04-07 01:12:36.449+0900 E/cluster-home(  869): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
04-07 01:12:36.459+0900 I/ESD     (  901): esd_main.c: __esd_app_dead_handler(1773) > pid: 9462
04-07 01:12:36.459+0900 W/cluster-view(  869): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
04-07 01:12:36.459+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 9462
04-07 01:12:36.459+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 9462
04-07 01:12:36.479+0900 I/Tizen::System( 1248): (157) > change brightness system value.
04-07 01:12:36.489+0900 I/TIZEN_N_SOUND_MANAGER(  919): sound_manager.c: sound_manager_get_volume(84) > returns : type=0, volume=9, ret=0x0
04-07 01:12:36.489+0900 E/TIZEN_N_SOUND_MANAGER(  919): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
04-07 01:12:36.489+0900 I/Tizen::App( 1248): (243) > App[org.example.client] pid[9462] terminate event is forwarded
04-07 01:12:36.489+0900 I/Tizen::System( 1248): (256) > osp.accessorymanager.service provider is found.
04-07 01:12:36.489+0900 I/Tizen::System( 1248): (196) > Accessory Owner is removed [org.example.client, 9462, ]
04-07 01:12:36.489+0900 I/Tizen::System( 1248): (256) > osp.system.service provider is found.
04-07 01:12:36.489+0900 I/Tizen::App( 1248): (506) > TerminatedApp(org.example.client)
04-07 01:12:36.489+0900 I/Tizen::App( 1248): (512) > Not registered pid(9462)
04-07 01:12:36.489+0900 I/Tizen::System( 1248): (246) > Terminated app [org.example.client]
04-07 01:12:36.489+0900 I/Tizen::Io( 1248): (729) > Entry not found
04-07 01:12:36.489+0900 I/Tizen::System( 1248): (157) > change brightness system value.
04-07 01:12:36.489+0900 I/Tizen::App( 1248): (782) > Finished invoking application event listener for org.example.client, 9462.
04-07 01:12:36.489+0900 I/TIZEN_N_SOUND_MANAGER(  919): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=15, ret=0x0
04-07 01:12:36.489+0900 E/TIZEN_N_SOUND_MANAGER(  919): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
04-07 01:12:36.500+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
04-07 01:12:36.560+0900 W/CRASH_MANAGER(10106): worker.c: worker_job(1199) > 0609462636c69149149515
